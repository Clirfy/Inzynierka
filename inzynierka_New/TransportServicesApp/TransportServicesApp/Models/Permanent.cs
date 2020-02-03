using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class Permanent : Advert
    {
        //1=codziennie 2=co tydzien 3=co miesiac
        public int RefreshPeriod { get; set; }
        public bool IsActive { get; set; }
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
