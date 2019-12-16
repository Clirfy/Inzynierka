using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOUT.ViewModels
{
    public class RegisterViewModel
    {
        //[Required]
        //[Remote(action: "IsUserNameInUseAsync", controller: "Account")]
        //public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUseAsync", controller: "Account")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdz hasło")]
        [Compare("Password", ErrorMessage = "Podane hasła są niezgodne")]
        public string ConfirmPassword { get; set; }
    }
}
