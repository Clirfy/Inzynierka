using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TransportServicesApp.Models;
using TransportServicesApp.ViewModels;

namespace TransportServicesApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly IAdvertRepository advertRepository;
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


        [HttpGet]
        public IActionResult SearchResult(string cityFrom, string cityTo, string advertType, List<SearchResultViewModel> model)
        {
            if (advertType == "Prośba")
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
                        UserName = item.UserName,
                        Expire = item.ExpireDate.Day.ToString() + "-" + item.ExpireDate.Month + "-" + item.ExpireDate.Year + " " + item.ExpireTime.TimeOfDay

                    };
                    model.Add(searchResultViewModel);
                }
                return View(model);
            }
            if (advertType == "Oferta")
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
                        SeatsTaken = item.SeatsTaken,
                        IsOccupied = item.IsOccupied,
                        AdvertType = item.AdvertType,
                        AdvertOption = item.AdvertOption,
                        UserImage = item.UserImage,
                        UserName = item.UserName,
                        Expire = item.ExpireDate.Day.ToString() + "-" + item.ExpireDate.Month + "-" + item.ExpireDate.Year + " " + item.ExpireTime.TimeOfDay

                    };
                    model.Add(searchResultViewModel);
                }
                return View(model);
            }
            //--------------------------------------------------------------------------------
            if (advertType == "All")
            {
                var requests = advertRepository.GetRequestResults(cityFrom, cityTo);
                foreach (var item in requests)
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
                        UserName = item.UserName,
                        Expire = item.ExpireDate.Day.ToString() + "-" + item.ExpireDate.Month + "-" + item.ExpireDate.Year + " " + item.ExpireTime.TimeOfDay

                    };
                    model.Add(searchResultViewModel);                    
                }
                var offers = advertRepository.GetOfferResults(cityFrom, cityTo);
                foreach (var item in offers)
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
                        SeatsTaken = item.SeatsTaken,
                        IsOccupied = item.IsOccupied,
                        AdvertType = item.AdvertType,
                        AdvertOption = item.AdvertOption,
                        UserImage = item.UserImage,
                        UserName = item.UserName,
                        Expire = item.ExpireDate.Day.ToString() + "-" + item.ExpireDate.Month + "-" + item.ExpireDate.Year + " " + item.ExpireTime.TimeOfDay

                    };
                    model.Add(searchResultViewModel);
                }
                return View(model);

                //////////////////////////////////////////////////////////////////////////////////
                //var adverts = advertRepository.GetAllResults(cityFrom, cityTo);
                //foreach (var item in adverts)
                //{
                //    foreach (var data in dbContext.Users)
                //    {
                //        if (data.Id == item.UserId)
                //        {
                //            item.UserImage = data.Image;
                //            item.UserName = data.UserName;
                //        }
                //    }
                //    var searchResultViewModel = new SearchResultViewModel
                //    {
                //        Id = item.Id,
                //        AdditionalBaggage = item.AdditionalBaggage,
                //        CityFrom = item.CityFrom,
                //        CityTo = item.CityTo,
                //        Description = item.Description,
                //        Size = item.Size,
                //        MaxSize = item.MaxSize,
                //        Weight = item.Weight,
                //        MaxWeight = item.MaxWeight,
                //        PassengerAmmount = item.PassengerAmmount,
                //        PassengerLimit = item.PassengerLimit,
                //        SeatsTaken = item.SeatsTaken,
                //        IsOccupied = item.IsOcuppied,
                //        AdvertType = item.AdvertType,
                //        IsFragile = item.IsFragile,
                //        AdvertOption = item.AdvertOption,
                //        UserImage = item.UserImage,
                //        UserName = item.UserName,
                //        Expire = item.ExpireDate.Day.ToString() + "-" + item.ExpireDate.Month + "-" + item.ExpireDate.Year + " " + item.ExpireTime.Hour + ":" + item.ExpireTime.Minute

                //    };
                //    model.Add(searchResultViewModel);
                //}
                //return View(model);
            }
            return View();
        }




        //-----------------JQuery autocomplete actions------------------
        public IActionResult GetCityFrom(string term)
        {
            var city = dbContext.Adverts
                .Where(n => n.CityFrom.ToLower().Contains(term.ToLower()))
                .Select(n => n.CityFrom).Distinct();

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


        [Authorize]
        [HttpGet]
        public IActionResult AdvertDetails(string advertId, AdvertDetailsViewModel model)
        {
            var advert = advertRepository.GetAdvert(advertId);
            var userEmail = dbContext.Users
                .Where(n => n.Id == advert.UserId)
                .Select(n => n.Email).FirstOrDefault();

            model.Id = advertId;
            model.Description = advert.Description;
            model.UserEmail = userEmail;

            return View(model);
        }

        public IActionResult BookAdvert(string email, string advertId)
        {
            var advert = advertRepository.GetOffer(advertId);
            if (advert.AdvertOption == 1)
            {
                advert.SeatsTaken += 1;
                advertRepository.UpdateOffer(advert);
            }
            try
            {
                SendMail(email);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index", "search");
        }

        private void SendMail(string email)
        {
            var userName = User.FindFirst(ClaimTypes.Name).Value;
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("sout", "souttrans1234@gmail.com"));
            message.To.Add(new MailboxAddress(email));
            message.Subject = "SOUT - dokonano rezerwacji na Twoje ogłoszenie";
            message.Body = new TextPart("plain")
            {
                Text = "Użytkownik " + userName + " zarezerwował miejsce w Twoim ogłoszeniu!"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("souttrans1234@gmail.com", "Sout1234");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
