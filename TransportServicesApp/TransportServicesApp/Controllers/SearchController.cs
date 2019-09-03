using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportServicesApp.Models;
using TransportServicesApp.ViewModels;

namespace TransportServicesApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly IAdvertRepository advertRepository;

        public SearchController(AppDbContext dbContext, IAdvertRepository advertRepository)
        {
            this.dbContext = dbContext;
            this.advertRepository = advertRepository;
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
        public IActionResult SearchResult(string cityFrom, string cityTo, string advertType)
        {
            if (advertType == "All")
            {
                var adverts = advertRepository.GetSearchResults(cityFrom, cityTo);

                return View(adverts);
            }
            else
            {
                var adverts = advertRepository.GetSearchResults(advertType, cityFrom, cityTo);

                return View(adverts);
            }
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
