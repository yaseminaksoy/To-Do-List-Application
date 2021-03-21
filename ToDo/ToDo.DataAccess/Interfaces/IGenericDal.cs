using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Interfaces;

namespace ToDo.DataAccess.Interfaces
{
    public interface IGenericDal<Table> where Table : class, ITable, new()
    {
        void Save(Table table);
        void Delete(Table table);
        void Update(Table table);
        Table GetWithId(int id);
        List<Table> GetAll();
    }
}
