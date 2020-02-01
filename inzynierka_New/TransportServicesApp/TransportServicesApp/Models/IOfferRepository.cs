using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public interface IOfferRepository
    {
        Offer AddOffer(Offer offer);
        IEnumerable<Offer> GetAllOffers();
        Offer GetOffer(string id);
        IEnumerable<Offer> GetUserOffers(string userId);
        Offer DeleteOffer(string offerId);
        Offer UpdateOffer(Offer offerChanges);
        IEnumerable<Offer> OfferSearchResults(string CityFrom, string CityTo);
    }
}
