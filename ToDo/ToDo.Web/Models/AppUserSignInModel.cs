using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Web.Models
{
    public class AppUserSignInModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Enter Username")]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
