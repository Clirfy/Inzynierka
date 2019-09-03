using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportServicesApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TransportServicesApp.Controllers
{
    public class AdvertManagerController : Controller
    {
        private readonly IAdvertRepository advertRepository;
        private readonly AppDbContext dbContext;

        public AdvertManagerController(IAdvertRepository advertRepository, AppDbContext dbContext)
        {
            this.advertRepository = advertRepository;
            this.dbContext = dbContext;
        }


        public ViewResult UserAdverts()
        {
            var id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var model = advertRepository.GetUserAdverts(id);
            return View(model);
        }



        //---------------Add Request---------------

        [HttpGet]
        public IActionResult AddRequestAdvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRequestAdvert(Advert model)
        {
            if (ModelState.IsValid)
            {
                model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                model.UserName = User.FindFirst(ClaimTypes.Name).Value;
                model.AdvertType = "Prośba";
                foreach (var item in dbContext.Users)
                {
                    if (item.Id == model.UserId)
                    {
                        model.UserImage = item.Image;
                    }
                }
                advertRepository.AddAdvert(model);

                return RedirectToAction("UserAdverts");
            }

            return View();
        }



        //---------------Add Passage---------------

        [HttpGet]
        public IActionResult AddPassageAdvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPassageAdvert(Advert model)
        {
            if (ModelState.IsValid)
            {
                model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                model.UserName = User.FindFirst(ClaimTypes.Name).Value;
                model.AdvertType = "Oferta";
                foreach (var item in dbContext.Users)
                {
                    if (item.Id == model.UserId)
                    {
                        model.UserImage = item.Image;
                    }
                }
                advertRepository.AddAdvert(model);

                return RedirectToAction("UserAdverts");
            }

            return View();
        }



        [HttpPost]
        public IActionResult DeleteAdvert(string id)
        {
            advertRepository.DeleteAdvert(id);
            return RedirectToAction("UserAdverts");
        }


        [HttpGet]
        public IActionResult EditAdvert(string id)
        {
            var advert = advertRepository.GetAdvert(id);
            return View(advert);
        }

        [HttpPost]
        public IActionResult EditAdvert(Advert model)
        {
            if (ModelState.IsValid)
            {
                model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                advertRepository.UpdateAdvert(model);
                return RedirectToAction("UserAdverts");
            }
            return View();
        }
    }
}
