using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class Advert
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string CityFrom { get; set; }

        [Required]
        public string CityTo { get; set; }




        //-----------Request details---------------

        public int RequestType { get; set; }

        public string PassengerAmmount { get; set; }

        public string Size { get; set; }

        public string Weight { get; set; }

        public bool IsFragile { get; set; }


        // space for additional baggage for both advert types
        public bool AdditionalBaggage { get; set; }



        //-----------Passage details---------------
        public int PassageType { get; set; }

        public string PassengerLimit { get; set; }

        public string MaxSize { get; set; }

        public string MaxWeight { get; set; }



        public string Description { get; set; }

        //UserData
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserImage { get; set; }


        public string AdvertType { get; set; }
    }
}
