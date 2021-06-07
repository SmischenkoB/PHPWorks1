using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseApp.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List<Worker> Workers { get; set; } = new List<Worker>();
    }
}
