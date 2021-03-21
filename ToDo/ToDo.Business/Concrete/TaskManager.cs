using System.Collections.Generic;
using ToDo.Business.Interfaces;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private readonly ITaskDal _taskDal;
        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public void Delete(Task table)
        {
            _taskDal.Delete(table);
        }

        public List<Task> GetAll()
        {
            return _taskDal.GetAll();
        }

        public List<Task> GetUncomplatedWithPriority()
        {
            return _taskDal.GetUncomplatedWithPriority();
        }

        public Task GetWithId(int id)
        {
            return _taskDal.GetWithId(id);
        }

        public void Save(Task table)
        {
            _taskDal.Save(table);
        }

        public void Update(Task table)
        {
            _taskDal.Update(table);
        }
    }
}
