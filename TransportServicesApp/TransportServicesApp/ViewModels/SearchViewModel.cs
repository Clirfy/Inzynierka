using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.ViewModels
{
    public class SearchViewModel
    {
        [Required]
        public string CityFrom { get; set; }

        [Required]
        public string CityTo { get; set; }

        [Required]
        public string AdvertType { get; set; }
    }
}
