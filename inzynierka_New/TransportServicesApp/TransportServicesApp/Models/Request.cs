using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class Request : Advert
    {
        //cargo
        public string Size { get; set; }
        public string Weight { get; set; }
        public bool IsFragile { get; set; }

        //passenger
        public string PassengerAmmount { get; set; }
        public bool AdditionalBaggage { get; set; }
    }
}
