using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Interfaces;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<Table> : IGenericDal<Table> where Table : class, ITable, new()
    {
        public void Delete(Table table)
        {
            using var context = new ToDoContext();
            context.Set<Table>().Remove(table);
            context.SaveChanges();
        }

        public List<Table> GetAll()
        {
            using var context = new ToDoContext();
            return context.Set<Table>().ToList();
        }

        public Table GetWithId(int id)
        {
            using var context = new ToDoContext();
            return context.Set<Table>().Find(id);
        }

        public void Save(Table table)
        {
            using var context = new ToDoContext();
            context.Add(table);
            context.SaveChanges();
        }

        public void Update(Table table)
        {
            using var context = new ToDoContext();
            context.Update(table);
            context.SaveChanges();
        }
    }
}
