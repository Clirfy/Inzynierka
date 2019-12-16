using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOUT.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Image { get; internal set; }
        public string Name { get; set; }
        public double Rating { get; set; }
    }
}
