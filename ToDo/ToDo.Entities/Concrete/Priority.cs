using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Interfaces;

namespace ToDo.Entities.Concrete
{
    public class Priority : ITable
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
