using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.ViewModels
{
    public class AddPassageAdvertViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string CityFrom { get; set; }

        [Required]
        public string CityTo { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }
        public DateTime ExpireTime { get; set; }


        //-----------Request details---------------

        public string PassengerAmmount { get; set; }

        public string Size { get; set; }

        public string Weight { get; set; }

        public bool IsFragile { get; set; }


        // space for additional baggage for both advert types
        public bool AdditionalBaggage { get; set; }


        //-----------Passage details---------------

        public string PassengerLimit { get; set; }
        public int SeatsTaken { get; set; }
        public bool IsOcuppied { get; set; }

        public string MaxSize { get; set; }

        public string MaxWeight { get; set; }



        public string Description { get; set; }

        //UserData
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserImage { get; set; }


        public string AdvertType { get; set; }

        //1=passenger 2=cargo 0=unid
        public int AdvertOption { get; set; }
    }
}
