using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class Offer : Advert
    {
        public int SeatsTaken { get; set; }
        public bool IsOccupied { get; set; }

        //cargo
        public string MaxSize { get; set; }
        public string MaxWeight { get; set; }

        //passenger
        public string PassengerLimit { get; set; }
        public bool AdditionalBaggage { get; set; }
    }
}
