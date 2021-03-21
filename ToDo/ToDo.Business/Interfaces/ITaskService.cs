using System.Collections.Generic;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Interfaces
{
    public interface ITaskService : IGenericService<Task>
    {
        List<Task> GetUncomplatedWithPriority();
    }
}
