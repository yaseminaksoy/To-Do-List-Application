using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Business.Interfaces;
using ToDo.Entities.Concrete;
using ToDo.Web.Areas.Admin.Models;

namespace ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PriorityController : Controller
    {
        private readonly IPriorityService _priorityService;
        public PriorityController(IPriorityService priorityService)
        {
            _priorityService = priorityService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "priority";

            List<Priority> priorities = _priorityService.GetAll();
            List<PriorityListViewModel> model = new List<PriorityListViewModel>();
            foreach (var priority in priorities)
            {
                PriorityListViewModel priorityListViewModel = new PriorityListViewModel();
                priorityListViewModel.Id = priority.Id;
                priorityListViewModel.Description = priority.Description;
                model.Add(priorityListViewModel);
            }
            return View(model);
        }
        public IActionResult AddPriorityTask()
        {
            TempData["Active"] = "priority";
            return View(new PriorityAddViewModel());
        }

        [HttpPost]
        public IActionResult AddPriorityTask(PriorityAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _priorityService.Save(new Priority()
                {
                    Description = model.Description
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult UpdatePriority(int id)
        {
            TempData["Active"] = "priority";
            var priority = _priorityService.GetWithId(id);
            PriorityUpdateViewModel model = new PriorityUpdateViewModel
            {
                Id = priority.Id,
                Description = priority.Description
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdatePriority(PriorityUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _priorityService.Update(new Priority
                {
                    Id = model.Id,
                    Description = model.Description
                });
                return RedirectToAction("Index");
            }
            return View(model);


        }
    }
}
