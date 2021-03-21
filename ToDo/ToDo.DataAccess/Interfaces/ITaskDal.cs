using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Interfaces
{
    public interface ITaskDal : IGenericDal<Task>
    {
        List<Task> GetUncomplatedWithPriority();
    }
}
