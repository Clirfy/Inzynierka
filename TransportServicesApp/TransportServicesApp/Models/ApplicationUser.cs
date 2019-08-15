using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Request> Requests { get; set; }
    }
}
