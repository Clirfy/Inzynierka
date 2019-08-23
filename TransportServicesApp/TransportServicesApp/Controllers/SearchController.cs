using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportServicesApp.Models;
using TransportServicesApp.ViewModels;

namespace TransportServicesApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext dbContext;

        public SearchController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
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



        [HttpGet]
        public IActionResult SearchResult(string cityFrom, string cityTo, string advertType)
        {
            if(advertType == "All")
            {
                var adverts = dbContext.Adverts
                .Where(n => n.CityFrom.ToLower() == cityFrom.ToLower())
                .Where(n => n.CityTo.ToLower() == cityTo.ToLower());

                return View(adverts);
            }
            else
            {
                var adverts = dbContext.Adverts
                .Where(n => n.CityFrom.ToLower() == cityFrom.ToLower())
                .Where(n => n.CityTo.ToLower() == cityTo.ToLower())
                .Where(n => n.AdvertType.ToLower() == advertType.ToLower());

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
    }

}
