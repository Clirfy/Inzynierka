using Hangfire;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public interface IHangfireRepository
    {
        void DeleteExpiredAdverts();
        void RefreshPermaAdverts();
    }

    public class HangfireRepo : IHangfireRepository
    {
        private readonly AppDbContext dbContext;
        private readonly IAdvertRepository advertRepository;

        public HangfireRepo(AppDbContext dbContext, IAdvertRepository advertRepository)
        {
            this.dbContext = dbContext;
            this.advertRepository = advertRepository;
        }

        public void DeleteExpiredAdverts()
        {
            foreach (var item in dbContext.Requests)
            {
                if (item.ExpireDate <= DateTime.Now &&
                    item.ExpireTime.Hour <= DateTime.Now.Hour &&
                    item.ExpireTime.Minute <= DateTime.Now.Minute)
                {
                    dbContext.Adverts.Remove(item);
                }
            }
            foreach (var item in dbContext.Offers)
            {
                if (item.ExpireDate <= DateTime.Now &&
                    item.ExpireTime.Hour <= DateTime.Now.Hour &&
                    item.ExpireTime.Minute <= DateTime.Now.Minute)
                {
                    dbContext.Adverts.Remove(item);
                }
            }
            //foreach (var item in dbContext.Permanents)
            //{
            //    if (item.ExpireDate <= DateTime.Now)
            //    {
            //        item.IsActive = false;
            //    }
            //}
            dbContext.SaveChanges();
        }

        public void RefreshPermaAdverts()
        {
            foreach (var item in dbContext.Permanents)
            {
                Permanent permanent = new Permanent
                {
                    CityFrom = item.CityFrom,
                    CityTo = item.CityTo,
                    ExpireDate = item.ExpireDate,
                    ExpireTime = item.ExpireTime,
                    AdditionalBaggage = item.AdditionalBaggage,
                    PassengerLimit = item.PassengerLimit,
                    MaxSize = item.MaxSize,
                    MaxWeight = item.MaxWeight,
                    SeatsTaken = 0,
                    IsOccupied = false,
                    Description = item.Description,
                    UserId = item.UserId,
                    UserName = item.UserName,
                    AdvertType = "Oferta Stała",
                    RefreshPeriod = item.RefreshPeriod
                };

                if (item.RefreshPeriod == 1 && item.ExpireDate <= DateTime.Now)
                {
                    permanent.ExpireDate = DateTime.Now;
                    permanent.IsActive = true;
                    var advert = dbContext.Permanents.Attach(permanent);
                    advert.State = EntityState.Modified;
                }
                if (item.RefreshPeriod == 2 && item.ExpireDate.Day == DateTime.Now.Day - 7)
                {
                    permanent.ExpireDate = DateTime.Now;
                    permanent.IsActive = true;
                    var advert = dbContext.Permanents.Attach(permanent);
                    advert.State = EntityState.Modified;
                }
                if (item.RefreshPeriod == 3 && item.ExpireDate.Month == DateTime.Now.Month - 1)
                {
                    permanent.ExpireDate = DateTime.Now;
                    permanent.IsActive = true;
                    var advert = dbContext.Permanents.Attach(permanent);
                    advert.State = EntityState.Modified;
                }
            }
        }
    }
}
