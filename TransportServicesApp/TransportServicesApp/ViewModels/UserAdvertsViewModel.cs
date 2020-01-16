using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.ViewModels
{
    public class UserAdvertsViewModel
    {
        // 0 - request; 1 - offer
        public string AdvertType { get; set; }
        public int AdvertOption { get; set; }
        public string Id { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime ExpireTime { get; set; }
        public string Expire { get; set; }


        //request
        public bool AdditionalBaggage { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
        public bool IsFragile { get; set; }
        public string PassengerAmmount { get; set; }

        //passage
        public string PassengerLimit { get; set; }
        public int SeatsTaken { get; set; }
        public bool IsOccupied { get; set; }
        public string MaxSize { get; set; }
        public string MaxWeight { get; set; }


        public string Description { get; set; }

        public string UserId { get; set; }
    }
}
