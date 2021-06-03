using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTables.Models
{
    public class Tasks
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool Complete { get; set; }
        public DateTime Date { get; set; }
        public string TaskType { get; set; }
    }
}
