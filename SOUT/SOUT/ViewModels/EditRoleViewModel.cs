using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOUT.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Nazwa roli jest wymagana")]
        [Display(Name = "Nazwa Roli")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
