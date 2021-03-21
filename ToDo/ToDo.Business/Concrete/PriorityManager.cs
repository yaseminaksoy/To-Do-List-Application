using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Interfaces;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Concrete
{
    public class PriorityManager : IPriorityService
    {
        private readonly IPriorityDal _priorityDal;
        public PriorityManager(IPriorityDal priorityDal)
        {
            _priorityDal = priorityDal;
        }
        public void Delete(Priority table)
        {
            _priorityDal.Delete(table);
        }

        public List<Priority> GetAll()
        {
            return _priorityDal.GetAll();
        }

        public Priority GetWithId(int id)
        {
            return _priorityDal.GetWithId(id);
        }

        public void Save(Priority table)
        {
            _priorityDal.Save(table);
        }

        public void Update(Priority table)
        {
            _priorityDal.Update(table);
        }
    }
}
