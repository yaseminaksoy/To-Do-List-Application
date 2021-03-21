using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Web.Models
{
    public class AppUserAddViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Enter Username")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Please enter same password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter email ")]

        public string Email { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter Name")]

        public string Name { get; set; }
        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Enter Surname")]

        public string Surname { get; set; }
    }
}
