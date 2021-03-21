using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Web.Areas.Admin.Models
{
    public class TaskAddViewModel
    {
        [Required(ErrorMessage = "Fill the name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please select a priority id")]
        public int PriorityId { get; set; }
        [Required(ErrorMessage ="Select a date")]
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateFinish { get; set; }

    }
}
