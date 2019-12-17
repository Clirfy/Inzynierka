using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public interface IAdvertRepository
    {
        // AdvertManagerController
        Advert AddAdvert(Advert advert);

        IEnumerable<Advert> GetAllAdverts();

        Advert GetAdvert(string Id);

        IEnumerable<Advert> GetUserAdverts(string userId);

        Advert DeleteAdvert(string advertId);

        Advert UpdateAdvert(Advert advertChanges);

        //SearchController
        IEnumerable<Advert> GetAllResults(string cityFrom, string cityTo);
        IEnumerable<Advert> GetRequestResults(string cityFrom, string cityTo);
        IEnumerable<Advert> GetOfferResults(string cityFrom, string cityTo);
    }
}
