using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class Passage
    {
        public Guid Id { get; set; }

        [Required]
        public string CityFrom { get; set; }

        [Required]
        public string CityTo { get; set; }

        public string PassageType { get; set; }


        //details
        public int PassengerLimit { get; set; }

        // has space for additional baggage
        public bool AdditionalBaggage { get; set; }

        public string Description { get; set; }

        public string MaxSize { get; set; }

        public int MaxWeight { get; set; }



        //UserData
        public string UserId { get; set; }

        public string UserName { get; set; }
    }
}
