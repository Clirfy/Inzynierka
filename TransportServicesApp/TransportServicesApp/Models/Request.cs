using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class Request
    {
        public string Id { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        public string RequestType { get; set; }
        public int PassengerAmmount { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public bool IsFragile { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public bool AdditionalBaggage { get; set; }
        public string AdvertType { get; set; }

    }
}
