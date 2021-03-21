using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfTaskRepository : EfGenericRepository<Task>, ITaskDal
    {
        public List<Task> GetUncomplatedWithPriority()
        {
            using (var context = new ToDoContext())
            {
                return context.Tasks.Include(I => I.Priority).Where(I => !I.Status).OrderByDescending(I => I.DateCreated).ToList();
            }
        }
    }
}
