using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToDo.Business.Interfaces;
using ToDo.Entities.Concrete;
using ToDo.Web.Areas.Admin.Models;

namespace ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IPriorityService _priorityService;
        public TaskController(ITaskService taskService, IPriorityService priorityService)
        {
            _taskService = taskService;
            _priorityService = priorityService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "task";
            List<Task> tasks = _taskService.GetUncomplatedWithPriority();
            List<TaskListViewModel> models = new List<TaskListViewModel>();
            foreach (var item in tasks)
            {
                TaskListViewModel model = new TaskListViewModel
                {
                    Description = item.Description,
                    Priority = item.Priority,
                    PriorityId = item.PriorityId,
                    Name = item.Name,
                    Status = item.Status,
                    Id = item.Id,
                    DateCreated = item.DateCreated,
                    DateFinish=item.DateFinish
                };
                models.Add(model);
                if (DateTime.Now.ToString("D") == item.DateFinish.ToString("D"))
                {
                    ViewBag.infoHeader = "true";
                }
            }
            return View(models);
        }
        public IActionResult AddTask()
        {
            TempData["Active"] = "task";

            ViewBag.Priorities = new SelectList(_priorityService.GetAll(), "Id", "Description");
            return View(new TaskAddViewModel());
        }
        [HttpPost]
        public IActionResult AddTask(TaskAddViewModel model)
        {

            if (ModelState.IsValid)
            {
                _taskService.Save(new Task
                {
                    Name = model.Name,
                    Description = model.Description,
                    PriorityId = model.PriorityId,
                    DateFinish=model.DateFinish
                });
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UpdateTask(int id)
        {
            TempData["Active"] = "task";
            var task = _taskService.GetWithId(id);
            TaskUpdateViewModel model = new TaskUpdateViewModel
            {
                Id = task.Id,
                Description = task.Description,
                PriorityId = task.PriorityId,
                Name = task.Name,
                DateFinish=task.DateFinish
            };
            ViewBag.Priorities = new SelectList(_priorityService.GetAll(), "Id", "Description", task.PriorityId);

            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateTask(TaskUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _taskService.Update(new Task()
                {
                    Id = model.Id,
                    Description = model.Description,
                    PriorityId = model.PriorityId,
                    Name = model.Name,
                    DateFinish=model.DateFinish
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult DeleteTask(int id)
        {
            _taskService.Delete(new Task { Id = id });
            return Json(null);
        }
    }
}
