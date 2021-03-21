using System;
using System.Collections.Generic;
using ToDo.Entities.Interfaces;

namespace ToDo.Entities.Concrete
{
    public class Task : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateFinish { get; set; }

        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
