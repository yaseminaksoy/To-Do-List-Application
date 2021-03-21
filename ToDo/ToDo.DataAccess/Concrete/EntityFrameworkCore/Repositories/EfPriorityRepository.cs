using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfPriorityRepository : EfGenericRepository<Priority>, IPriorityDal
    {

    }
}
