using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TransportServicesApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TransportServicesApp.Controllers
{
    public class AdvertManagerController : Controller
    {
        private readonly IRequestRepository requestRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IPassageRepository passageRepository;

        public AdvertManagerController(IRequestRepository requestRepository, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, IPassageRepository passageRepository)
        {
            this.requestRepository = requestRepository;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.passageRepository = passageRepository;
        }
        //TODO ViewModel for both requests and passages in order to display 
        public ViewResult Index()
        {
            var model = requestRepository.GetAllRequests();
            return View(model);
        }



        // ----------------Request Advert--------------------


        [HttpGet]
        public IActionResult AddRequestAdvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRequestAdvert(Request model)
        {
            if (ModelState.IsValid)
            {
                model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                model.UserName = User.FindFirst(ClaimTypes.Name).Value;
                requestRepository.AddRequest(model);
            }

            return View();
        }

        //TODO create href/anchor in navbar for useradverts
        [HttpGet]
        public IActionResult UserRequestAdverts()
        {
            var id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var advert = requestRepository.GetUserRequests(id);

            return View(advert);
        }



        // ----------------Passage Advert--------------------

        [HttpGet]
        public IActionResult AddPassageAdvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPassageAdvert(Passage model)
        {
            if (ModelState.IsValid)
            {
                model.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                model.UserName = User.FindFirst(ClaimTypes.Name).Value;
                passageRepository.AddPassage(model);
            }

            return View();
        }

        [HttpGet]
        public IActionResult UserPassageAdverts()
        {
            var id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var advert = passageRepository.GetUserPassages(id);

            return View(advert);
        }
    }
}
