using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportServicesApp.ViewModels;

namespace TransportServicesApp.Models
{
    public class SQLAdvertRespository : IAdvertRepository
    {
        private readonly AppDbContext dbContext;

        public SQLAdvertRespository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Advert AddAdvert(Advert advert)
        {
            dbContext.Adverts.Add(advert);
            dbContext.SaveChanges();

            return advert;
        }

        public Permanent AddPermanent(Permanent permanent)
        {
            dbContext.Permanents.Add(permanent);
            dbContext.SaveChanges();
            return permanent;
        }

        public Advert DeleteAdvert(string advertId)
        {
            var advert = dbContext.Adverts.Find(advertId);
            if (advert != null)
            {
                dbContext.Adverts.Remove(advert);
                dbContext.SaveChanges();
            }
            return advert;
        }

        public Advert GetAdvert(string Id)
        {
            return dbContext.Adverts.Find(Id);
        }

        public IEnumerable<Advert> GetAllAdverts()
        {
            return dbContext.Adverts;
        }

        public IEnumerable<Advert> GetAllResults(string cityFrom, string cityTo)
        {
            return dbContext.Adverts
                .Where(n => n.CityFrom == cityFrom)
                .Where(n => n.CityTo == cityTo);
        }

        public Offer GetOffer(string Id)
        {
            return dbContext.Offers.Find(Id);
        }

        public IEnumerable<Offer> GetOfferResults(string cityFrom, string cityTo)
        {
            return dbContext.Offers
                .Where(n => n.CityFrom == cityFrom)
                .Where(n => n.CityTo == cityTo)
                .Where(n => n.AdvertType == "Oferta");
        }

        public Permanent GetPermanent(string Id)
        {
            return dbContext.Permanents.Find(Id);
        }

        public Request GetRequest(string Id)
        {
            return dbContext.Requests.Find(Id);
        }

        public IEnumerable<Request> GetRequestResults(string cityFrom, string cityTo)
        {
            return dbContext.Requests
                .Where(n => n.CityFrom == cityFrom)
                .Where(n => n.CityTo == cityTo)
                .Where(n => n.AdvertType == "Prośba");

        }


        public IEnumerable<Advert> GetUserAdverts(string userId)
        {
            return dbContext.Adverts.Where(n => n.UserId == userId);
        }
        public IEnumerable<Offer> GetUserOffers(string userId)
        {
            return dbContext.Offers.Where(n => n.UserId == userId);
        }

        public IEnumerable<Permanent> GetUserPermanents(string userId)
        {
            return dbContext.Permanents.Where(n => n.UserId == userId);
        }

        public IEnumerable<Request> GetUserRequests(string userId)
        {
            return dbContext.Requests.Where(n => n.UserId == userId);
        }


        public Advert UpdateAdvert(Advert advertChanges)
        {
            var advert = dbContext.Adverts.Attach(advertChanges);
            advert.State = EntityState.Modified;
            dbContext.SaveChanges();

            return advertChanges;
        }

        public Offer UpdateOffer(Offer offerChanges)
        {
            var advert = dbContext.Offers.Attach(offerChanges);
            advert.State = EntityState.Modified;
            dbContext.SaveChanges();

            return offerChanges;
        }

        public Permanent UpdatePermanent(Permanent permanentChanges)
        {
            var advert = dbContext.Permanents.Attach(permanentChanges);
            advert.State = EntityState.Modified;
            dbContext.SaveChanges();

            return permanentChanges;
        }

        public Request UpdateRequest(Request requestChanges)
        {
            var advert = dbContext.Requests.Attach(requestChanges);
            advert.State = EntityState.Modified;
            dbContext.SaveChanges();

            return requestChanges;
        }
    }
}
