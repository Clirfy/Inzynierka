using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.ViewModels
{
    public class EditAdvertViewModel
    {
        public string Id { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }



        public string PassengerAmmount { get; set; }

        public string Size { get; set; }

        public string Weight { get; set; }

        public bool IsFragile { get; set; }


        public bool AdditionalBaggage { get; set; }




        public string PassengerLimit { get; set; }

        public string MaxSize { get; set; }

        public string MaxWeight { get; set; }



        public string Description { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserImage { get; set; }


        public string AdvertType { get; set; }
        public int AdvertOption { get; set; }
    }
}
