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
            var advert = advertRepository.GetUserAdverts(id);

            foreach (var item in advert)
            {
                var userAdvertsViewModel = new UserAdvertsViewModel
                {
                    Id = item.Id,
                    AdditionalBaggage = item.AdditionalBaggage,
                    CityFrom = item.CityFrom,
                    CityTo = item.CityTo,
                    Description = item.Description,
                    Size = item.Size,
                    Weight = item.Weight,
                    PassengerAmmount = item.PassengerAmmount,
                    IsOccupied = item.IsOcuppied,
                    SeatsTaken = item.SeatsTaken,
                    IsFragile = item.IsFragile,
                    MaxSize = item.MaxSize,
                    MaxWeight = item.MaxWeight,
                    PassengerLimit = item.PassengerLimit,
                    AdvertType = item.AdvertType,
                    AdvertOption = item.AdvertOption,
                    Expire = item.ExpireDate.Day.ToString() + "-" + item.ExpireDate.Month + "-" + item.ExpireDate.Year + " " + item.ExpireTime.TimeOfDay
                };
                model.Add(userAdvertsViewModel);
            }

            return View(model);
            //var id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //var requests = requestRepository.GetUserRequests(id);
            //var offers = offerRepository.GetUserOffers(id);

            //foreach (var item in requests)
            //{
            //    var userAdvertsViewModel = new UserAdvertsViewModel
            //    {
            //        Id = item.Id,
            //        AdditionalBaggage = item.AdditionalBaggage,
            //        CityFrom = item.CityFrom,
            //        CityTo = item.CityTo,
            //        Description = item.Description,
            //        Size = item.Size,
            //        Weight = item.Weight,
            //        PassengerAmmount = item.PassengerAmmount,
            //        AdvertType = item.AdvertType,
            //        IsFragile = item.IsFragile,
            //        RequestType = item.RequestType
            //    };
            //    model.Add(userAdvertsViewModel);
            //}
            //foreach (var item in offers)
            //{
            //    var userAdvertsViewModel = new UserAdvertsViewModel
            //    {
            //        Id = item.Id,
            //        AdditionalBaggage = item.AdditionalBaggage,
            //        CityFrom = item.CityFrom,
            //        CityTo = item.CityTo,
            //        Description = item.Description,
            //        MaxSize = item.MaxSize,
            //        MaxWeight = item.MaxWeight,
            //        PassengerLimit = item.PassengerLimit,
            //        AdvertType = item.AdvertType,
            //        OfferType = item.OfferType
            //    };
            //    model.Add(userAdvertsViewModel);
            //}

            //return View(model);
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
                advertRepository.AddAdvert(model);
                return RedirectToAction("UserAdverts");
            }

            return View();
        }
        //[HttpPost]
        //public IActionResult AddRequestAdvert(Advert model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        //        model.UserName = User.FindFirst(ClaimTypes.Name).Value;
        //        model.AdvertType = "Prośba";
        //        foreach (var item in dbContext.Users)
        //        {
        //            if (item.Id == model.UserId)
        //            {
        //                model.UserImage = item.Image;
        //            }
        //        }
        //        advertRepository.AddAdvert(model);

        //        return RedirectToAction("UserAdverts");
        //    }

        //    return View();
        //}


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
                advertRepository.AddAdvert(model);
                return RedirectToAction("UserAdverts");
            }

            return View();
            //if (ModelState.IsValid)
            //{
            //    model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //    model.UserName = User.FindFirst(ClaimTypes.Name).Value;
            //    model.AdvertType = "Oferta";
            //    foreach (var item in dbContext.Users)
            //    {
            //        if (item.Id == model.UserId)
            //        {
            //            model.UserImage = item.Image;
            //        }
            //    }
            //    advertRepository.AddAdvert(model);

            //    return RedirectToAction("UserAdverts");
            //}

            //return View();
        }



        [HttpPost]
        public IActionResult DeleteAdvert(string id)
        {
            advertRepository.DeleteAdvert(id);
            //if(requestRepository.GetRequest(id) != null)
            //{
            //    requestRepository.DeleteRequest(id);
            //}
            //if(offerRepository.GetOffer(id) != null)
            //{
            //    offerRepository.DeleteOffer(id);
            //}
            //advertRepository.DeleteAdvert(id);
            return RedirectToAction("UserAdverts");
        }

        [HttpGet]
        public IActionResult EditAdvert(string id, EditAdvertViewModel model)
        {
            var advert = advertRepository.GetAdvert(id);
            model.Id = advert.Id;
            model.CityFrom = advert.CityFrom;
            model.CityTo = advert.CityTo;
            model.PassengerAmmount = advert.PassengerAmmount;
            model.PassengerLimit = advert.PassengerLimit;
            model.Size = advert.Size;
            model.MaxSize = advert.MaxSize;
            model.Weight = advert.Weight;
            model.MaxWeight = advert.MaxWeight;
            model.IsFragile = advert.IsFragile;
            model.Description = advert.Description;
            model.AdditionalBaggage = advert.AdditionalBaggage;
            model.AdvertType = advert.AdvertType;
            model.AdvertOption = advert.AdvertOption;
            model.ExpireDate = advert.ExpireDate;
            model.ExpireTime = advert.ExpireTime;

            return View(model);
            //if (requestRepository.GetRequest(id) != null)
            //{
            //    var request = requestRepository.GetRequest(id);
            //    model.AdvertType = request.AdvertType;
            //    model.Id = request.Id;
            //    model.CityFrom = request.CityFrom;
            //    model.CityTo = request.CityTo;
            //    model.RequestType = request.RequestType;
            //    model.PassengerAmmount = request.PassengerAmmount;
            //    model.Size = request.Size;
            //    model.Weight = request.Weight;
            //    model.IsFragile = request.IsFragile;
            //    model.Description = request.Description;
            //    model.AdditionalBaggage = request.AdditionalBaggage;
            //    return View(model);
            //}
            //else if (offerRepository.GetOffer(id) != null)
            //{
            //    var offer = offerRepository.GetOffer(id);
            //    model.AdvertType = offer.AdvertType;
            //    model.Id = offer.Id;
            //    model.CityFrom = offer.CityFrom;
            //    model.CityTo = offer.CityTo;
            //    model.OfferType = offer.OfferType;
            //    model.PassengerLimit = offer.PassengerLimit;
            //    model.MaxSize = offer.MaxSize;
            //    model.MaxWeight = offer.MaxWeight;
            //    model.Description = offer.Description;
            //    model.AdditionalBaggage = offer.AdditionalBaggage;
            //    return View(model);
            //}
            //return View();
        }

        [HttpPost]
        public IActionResult EditAdvert(EditAdvertViewModel model, Advert advert)
        {
            if (ModelState.IsValid)
            {
                advert.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                advertRepository.UpdateAdvert(advert);
                return RedirectToAction("UserAdverts");
            }
            //if (ModelState.IsValid && model.AdvertType == "Prośba")
            //{
            //    request.UserID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //    requestRepository.UpdateRequest(request);
            //    return RedirectToAction("UserAdverts");
            //}
            //else if (ModelState.IsValid && model.AdvertType == "Oferta")
            //{
            //    offer.UserID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //    offerRepository.UpdateOffer(offer);
            //    return RedirectToAction("UserAdverts");
            //}
            return View();
        }
    }
}
