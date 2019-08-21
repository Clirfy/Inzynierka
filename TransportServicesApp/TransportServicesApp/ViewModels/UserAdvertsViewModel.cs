using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.ViewModels
{
    public class UserAdvertsViewModel
    {
        // 0 - request; 1 - passage
        public string AdvertType { get; set; }

        public string CityFrom { get; set; }
        public string CityTo { get; set; }

        //request
        public bool AdditionalBaggage { get; set; }
        public int Weight { get; set; }
        public string Size { get; set; }
        public bool IsFragile { get; set; }

        //passage
        public int PassengerLimit { get; set; }
        public string MaxSize { get; set; }
        public int MaxWeight { get; set; }
        public int PassengerAmmount { get; set; }


        public string Description { get; set; }

        public string UserId { get; set; }
    }
}
