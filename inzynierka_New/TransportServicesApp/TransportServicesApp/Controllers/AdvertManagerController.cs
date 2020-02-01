using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportServicesApp.Models;
using TransportServicesApp.ViewModels;

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

        public ViewResult UserAdverts(List<UserAdvertsViewModel> model)
        {
            var id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var offer = advertRepository.GetUserOffers(id);
            var request = advertRepository.GetUserRequests(id);

            foreach (var item in offer)
            {
                var userAdvertsViewModel = new UserAdvertsViewModel
                {
                    Id = item.Id,
                    AdditionalBaggage = item.AdditionalBaggage,
                    CityFrom = item.CityFrom,
                    CityTo = item.CityTo,
                    Description = item.Description,
                    IsOccupied = item.IsOccupied,
                    SeatsTaken = item.SeatsTaken,
                    MaxSize = item.MaxSize,
                    MaxWeight = item.MaxWeight,
                    PassengerLimit = item.PassengerLimit,
                    AdvertType = item.AdvertType,
                    AdvertOption = item.AdvertOption,
                    Expire = item.ExpireDate.Day.ToString() + "-" + item.ExpireDate.Month + "-" + item.ExpireDate.Year + " " + item.ExpireTime.TimeOfDay
                };
                model.Add(userAdvertsViewModel);
            }
            foreach (var item in request)
            {
                var userAdvertsViewModel = new UserAdvertsViewModel
                {
                    Id = item.Id,
                    AdditionalBaggage = item.AdditionalBaggage,
                    CityFrom = item.CityFrom,
                    CityTo = item.CityTo,
                    Size = item.Size,
                    Weight = item.Weight,
                    IsFragile = item.IsFragile,
                    PassengerAmmount = item.PassengerAmmount,
                    Description = item.Description,
                    AdvertType = item.AdvertType,
                    AdvertOption = item.AdvertOption,
                    Expire = item.ExpireDate.Day.ToString() + "-" + item.ExpireDate.Month + "-" + item.ExpireDate.Year + " " + item.ExpireTime.TimeOfDay
                };
                model.Add(userAdvertsViewModel);
            }

            return View(model);
        }

        //---------------Add Request---------------

        [HttpGet]
        public IActionResult AddRequestAdvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRequestAdvert(AddRequestViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var userName = model.UserName = User.FindFirst(ClaimTypes.Name).Value;

                Request request = new Request
                {
                    CityFrom = model.CityFrom,
                    CityTo = model.CityTo,
                    ExpireDate = model.ExpireDate,
                    ExpireTime = model.ExpireTime,
                    AdditionalBaggage = model.AdditionalBaggage,
                    PassengerAmmount = model.PassengerAmmount,
                    Size = model.Size,
                    Weight = model.Weight,
                    IsFragile = model.IsFragile,
                    Description = model.Description,
                    UserId = userId,
                    UserName = userName,
                    AdvertType = "Prośba",
                    AdvertOption = model.AdvertOption
                };

                advertRepository.AddAdvert(request);
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
        public IActionResult AddPassageAdvert(AddPassageAdvertViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var userName = model.UserName = User.FindFirst(ClaimTypes.Name).Value;
                //advertRepository.AddAdvert(model);

                Offer offer = new Offer
                {
                    CityFrom = model.CityFrom,
                    CityTo = model.CityTo,
                    ExpireDate = model.ExpireDate,
                    ExpireTime = model.ExpireTime,
                    AdditionalBaggage = model.AdditionalBaggage,
                    PassengerLimit = model.PassengerLimit,
                    MaxSize = model.MaxSize,
                    MaxWeight = model.MaxWeight,
                    SeatsTaken = 0,
                    IsOccupied = false,
                    Description = model.Description,
                    UserId = userId,
                    UserName = userName,
                    AdvertType = "Oferta",
                    AdvertOption = model.AdvertOption
                };

                advertRepository.AddAdvert(offer);
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
        public IActionResult EditAdvert(string id, EditAdvertViewModel model)
        {
            if(advertRepository.GetRequest(id) != null)
            {
                var request = advertRepository.GetRequest(id);
                model.AdvertType = request.AdvertType;
                model.Id = request.Id;
                model.CityFrom = request.CityFrom;
                model.CityTo = request.CityTo;
                model.AdvertOption = request.AdvertOption;
                model.PassengerAmmount = request.PassengerAmmount;
                model.Size = request.Size;
                model.Weight = request.Weight;
                model.IsFragile = request.IsFragile;
                model.Description = request.Description;
                model.AdditionalBaggage = request.AdditionalBaggage;
                return View(model);
            }
            if(advertRepository.GetOffer(id) != null)
            {
                var offer = advertRepository.GetOffer(id);
                model.AdvertType = offer.AdvertType;
                model.Id = offer.Id;
                model.CityFrom = offer.CityFrom;
                model.CityTo = offer.CityTo;
                model.AdvertOption = offer.AdvertOption;
                model.PassengerLimit = offer.PassengerLimit;
                model.MaxSize = offer.MaxSize;
                model.MaxWeight = offer.MaxWeight;
                model.Description = offer.Description;
                model.AdditionalBaggage = offer.AdditionalBaggage;
                return View(model);

            }
            return View(model);
        }

        [HttpPost]
        public IActionResult EditAdvert(EditAdvertViewModel model, Advert advert, Offer offer, Request request)
        {
            if (ModelState.IsValid)
            {
                if (model.AdvertType == "Prośba")
                {
                    request.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    advertRepository.UpdateRequest(request);
                    return RedirectToAction("UserAdverts");
                }
                if (model.AdvertType == "Oferta")
                {
                    offer.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    advertRepository.UpdateOffer(offer);
                    return RedirectToAction("UserAdverts");
                }
            }
            return View();
        }
    }
}
