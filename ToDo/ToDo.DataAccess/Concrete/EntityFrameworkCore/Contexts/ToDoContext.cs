using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class ToDoContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=ToDoListApplication; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskMap());
            modelBuilder.ApplyConfiguration(new PriorityMap());
            modelBuilder.ApplyConfiguration(new AppUserMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}
