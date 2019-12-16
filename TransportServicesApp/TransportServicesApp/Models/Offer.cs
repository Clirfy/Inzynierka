using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class Offer
    {
        public string Id { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        public string OfferType { get; set; }
        public int PassengerLimit { get; set; }
        public string MaxSize { get; set; }
        public string MaxWeight { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public bool AdditionalBaggage { get; set; }
        public string AdvertType { get; set; }
    }
}
