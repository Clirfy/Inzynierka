using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class Request
    {
        public Guid Id { get; set; }

        [Required]
        public string CityFrom { get; set; }

        [Required]
        public string CityTo { get; set; }

        [Required]
        public string RequestType { get; set; }


        //details
        public int PassengerAmmount { get; set; }

        public bool AdditionalBaggage { get; set; }

        public string Description { get; set; }

        public string Size { get; set; }

        //TODO 
        public string Weight { get; set; }

        public bool IsFragile { get; set; }


        //UserData
        public string UserId { get; set; }

        public string UserName { get; set; }

    }

}
