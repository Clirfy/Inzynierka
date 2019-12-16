using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.ViewModels
{
    public class SearchResultViewModel
    {
        // 0 - request; 1 - passage
        public string AdvertType { get; set; }
        public string Id { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }

        //request
        public bool AdditionalBaggage { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
        public bool IsFragile { get; set; }
        public int PassengerAmmount { get; set; }
        public string RequestType { get; set; }

        //passage
        public int PassengerLimit { get; set; }
        public string MaxSize { get; set; }
        public string MaxWeight { get; set; }
        public string OfferType { get; set; }


        public string Description { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
    }
}
