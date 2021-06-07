using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseApp.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}
