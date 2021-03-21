using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Web.Areas.Admin.Models
{
    public class PriorityAddViewModel
    {
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Fill the description")]
        public string Description { get; set; }
    }
}
