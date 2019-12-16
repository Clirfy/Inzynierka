using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TransportServicesApp.Models;
using TransportServicesApp.ViewModels;

namespace TransportServicesApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly IAdvertRepository advertRepository;
        private readonly IRequestRepository requestRepository;
        private readonly IOfferRepository offerRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public SearchController(AppDbContext dbContext, IAdvertRepository advertRepository,
            IRequestRepository requestRepository, IOfferRepository offerRepository, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.advertRepository = advertRepository;
            this.requestRepository = requestRepository;
            this.offerRepository = offerRepository;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("SearchResult", "Search",
                    new
                    {
                        cityFrom = model.CityFrom,
                        cityTo = model.CityTo,
                        advertType = model.AdvertType
                    });
            }
            return View(model);
        }


        // TODO avatar przypisuje się do oferty przez co przy zmianie avatara w ofercie nie zmieni się
        // AdvertManagerController/AddRequestAdvert + AddPassageAdvert
        [HttpGet]
        public IActionResult SearchResult(string cityFrom, string cityTo, string advertType, List<SearchResultViewModel> model)
        {
            if(advertType == "Prośba")
            {
                var adverts = requestRepository.RequestSearchResults(cityFrom, cityTo);
                foreach (var item in adverts)
                {
                    var searchResultViewModel = new SearchResultViewModel
                    {
                        Id = item.Id,
                        AdditionalBaggage = item.AdditionalBaggage,
                        CityFrom = item.CityFrom,
                        CityTo = item.CityTo,
                        Description = item.Description,
                        Size = item.Size,
                        Weight = item.Weight,
                        PassengerAmmount = item.PassengerAmmount,
                        AdvertType = item.AdvertType,
                        IsFragile = item.IsFragile,
                        RequestType = item.RequestType
                    };
                    model.Add(searchResultViewModel);
                }
                return View(model);
            }
            if(advertType == "Oferta")
            {
                var adverts = offerRepository.OfferSearchResults(cityFrom, cityTo);
                foreach (var item in adverts)
                {
                    var searchResultViewModel = new SearchResultViewModel
                    {
                        Id = item.Id,
                        AdditionalBaggage = item.AdditionalBaggage,
                        CityFrom = item.CityFrom,
                        CityTo = item.CityTo,
                        Description = item.Description,
                        MaxSize = item.MaxSize,
                        MaxWeight = item.MaxWeight,
                        PassengerLimit = item.PassengerLimit,
                        AdvertType = item.AdvertType,
                        OfferType = item.OfferType
                    };
                    model.Add(searchResultViewModel);
                }
                return View(adverts);
            }
            if (advertType == "All")
            {
                var requests = requestRepository.RequestSearchResults(cityFrom, cityTo);
                var offers = offerRepository.OfferSearchResults(cityFrom, cityTo);
                foreach (var item in requests)
                {
                    var searchResultViewModel = new SearchResultViewModel
                    {
                        Id = item.Id,
                        AdditionalBaggage = item.AdditionalBaggage,
                        CityFrom = item.CityFrom,
                        CityTo = item.CityTo,
                        Description = item.Description,
                        Size = item.Size,
                        Weight = item.Weight,
                        PassengerAmmount = item.PassengerAmmount,
                        AdvertType = item.AdvertType,
                        IsFragile = item.IsFragile,
                        RequestType = item.RequestType
                    };
                    model.Add(searchResultViewModel);
                }
                foreach (var item in offers)
                {
                    var searchResultViewModel = new SearchResultViewModel
                    {
                        Id = item.Id,
                        AdditionalBaggage = item.AdditionalBaggage,
                        CityFrom = item.CityFrom,
                        CityTo = item.CityTo,
                        Description = item.Description,
                        MaxSize = item.MaxSize,
                        MaxWeight = item.MaxWeight,
                        PassengerLimit = item.PassengerLimit,
                        AdvertType = item.AdvertType,
                        OfferType = item.OfferType
                    };
                    model.Add(searchResultViewModel);
                }
                return View(model);
            }
            return View();
        }




        //-----------------JQuery autocomplete actions------------------
        public IActionResult GetCityFrom(string term)
        {
            var city = dbContext.Requests
                .Where(n => n.CityFrom.ToLower().Contains(term.ToLower()))
                .Select(n => n.CityFrom).Distinct();

            //var result = (from n in dbContext.Adverts
            //              where n.CityFrom.ToLower().Contains(term.ToLower())
            //              select new { value = n.CityFrom }).Distinct();

            return Json(city);
        }

        public IActionResult GetCityTo(string term)
        {
            var city = dbContext.Requests
                .Where(n => n.CityTo.ToUpper().Contains(term.ToUpper()))
                .Select(n => n.CityTo).Distinct();

            return Json(city);
        }
        //-----------------^^JQuery autocomplete actions^^------------------
    }

}
