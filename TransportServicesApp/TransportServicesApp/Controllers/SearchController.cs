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

        public SearchController(AppDbContext dbContext, IAdvertRepository advertRepository, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.advertRepository = advertRepository;
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
                var adverts = advertRepository.GetRequestResults(cityFrom, cityTo);
                foreach (var item in adverts)
                {
                    foreach (var data in dbContext.Users)
                    {
                        if (data.Id == item.UserId)
                        {
                            item.UserImage = data.Image;
                            item.UserName = data.UserName;
                        }
                    }
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
                        AdvertOption = item.AdvertOption,
                        UserImage = item.UserImage,
                        UserName = item.UserName
                    };
                    model.Add(searchResultViewModel);
                }
                return View(model);
            }
            if(advertType == "Oferta")
            {
                var adverts = advertRepository.GetOfferResults(cityFrom, cityTo);
                foreach (var item in adverts)
                {
                    foreach (var data in dbContext.Users)
                    {
                        if (data.Id == item.UserId)
                        {
                            item.UserImage = data.Image;
                            item.UserName = data.UserName;
                        }
                    }
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
                        AdvertOption = item.AdvertOption,
                        UserImage = item.UserImage,
                        UserName = item.UserName
                    };
                    model.Add(searchResultViewModel);
                }
                return View(model);
            }
            if (advertType == "All")
            {
                var adverts = advertRepository.GetAllResults(cityFrom, cityTo);
                foreach (var item in adverts)
                {
                    foreach (var data in dbContext.Users)
                    {
                        if (data.Id == item.UserId)
                        {
                            item.UserImage = data.Image;
                            item.UserName = data.UserName;
                        }
                    }
                    var searchResultViewModel = new SearchResultViewModel
                    {
                        Id = item.Id,
                        AdditionalBaggage = item.AdditionalBaggage,
                        CityFrom = item.CityFrom,
                        CityTo = item.CityTo,
                        Description = item.Description,
                        Size = item.Size,
                        MaxSize = item.MaxSize,
                        Weight = item.Weight,
                        MaxWeight = item.MaxWeight,
                        PassengerAmmount = item.PassengerAmmount,
                        PassengerLimit = item.PassengerLimit,
                        AdvertType = item.AdvertType,
                        IsFragile = item.IsFragile,
                        AdvertOption = item.AdvertOption,
                        UserImage = item.UserImage,
                        UserName = item.UserName
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
            var city = dbContext.Adverts
                .Where(n => n.CityFrom.ToLower().Contains(term.ToLower()))
                .Select(n => n.CityFrom).Distinct();

            //var result = (from n in dbContext.Adverts
            //              where n.CityFrom.ToLower().Contains(term.ToLower())
            //              select new { value = n.CityFrom }).Distinct();

            return Json(city);
        }

        public IActionResult GetCityTo(string term)
        {
            var city = dbContext.Adverts
                .Where(n => n.CityTo.ToUpper().Contains(term.ToUpper()))
                .Select(n => n.CityTo).Distinct();

            return Json(city);
        }
        //-----------------^^JQuery autocomplete actions^^------------------
    }

}
