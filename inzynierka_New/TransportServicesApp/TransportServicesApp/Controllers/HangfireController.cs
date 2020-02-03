using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using TransportServicesApp.Models;

namespace TransportServicesApp.Controllers
{
        [Route("Api/Hangfire")]
    public class HangfireController : Controller
    {
        private readonly IHangfireRepository hangfire;

        public HangfireController(IHangfireRepository hangfire)
        {
            this.hangfire = hangfire;
        }
        [HttpGet]
        public IActionResult Index()
        {
            RecurringJob.AddOrUpdate(() => hangfire.DeleteExpiredAdverts(), Cron.Daily);
            RecurringJob.AddOrUpdate(() => hangfire.RefreshPermaAdverts(), Cron.Daily);

            return Ok();
        }
    }
}