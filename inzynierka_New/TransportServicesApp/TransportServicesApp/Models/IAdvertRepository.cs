﻿using System;
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
        Offer GetOffer(string Id);
        Request GetRequest(string Id);

        IEnumerable<Advert> GetUserAdverts(string userId);
        IEnumerable<Offer> GetUserOffers(string userId);
        IEnumerable<Request> GetUserRequests(string userId);

        Advert DeleteAdvert(string advertId);

        Advert UpdateAdvert(Advert advertChanges);
        Offer UpdateOffer(Offer offerChanges);
        Request UpdateRequest(Request requestChanges);

        //SearchController
        IEnumerable<Advert> GetAllResults(string cityFrom, string cityTo);
        IEnumerable<Request> GetRequestResults(string cityFrom, string cityTo);
        IEnumerable<Offer> GetOfferResults(string cityFrom, string cityTo);
    }
}
