using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class SQLOfferRepository : IOfferRepository
    {
        private readonly AppDbContext dbContext;

        public SQLOfferRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Offer AddOffer(Offer offer)
        {
            dbContext.Offers.Add(offer);
            dbContext.SaveChanges();
            return offer;
        }

        public Offer DeleteOffer(string offerId)
        {
            var offer = dbContext.Offers.Find(offerId);

            if (offer != null)
            {
                dbContext.Offers.Remove(offer);
                dbContext.SaveChanges();
            }
            return offer;
        }

        public IEnumerable<Offer> GetAllOffers()
        {
            return dbContext.Offers;
        }

        public Offer GetOffer(string id)
        {
            return dbContext.Offers.Find(id);
        }

        public IEnumerable<Offer> GetUserOffers(string userId)
        {
            return dbContext.Offers.Where(n => n.UserID == userId);
        }

        public IEnumerable<Offer> OfferSearchResults(string CityFrom, string CityTo)
        {
            return dbContext.Offers
                .Where(n => n.CityFrom == CityFrom)
                .Where(n => n.CityTo == CityTo);
        }

        public Offer UpdateOffer(Offer offerChanges)
        {
            var offer = dbContext.Offers.Attach(offerChanges);
            offer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

            return offerChanges;
        }
    }
}
