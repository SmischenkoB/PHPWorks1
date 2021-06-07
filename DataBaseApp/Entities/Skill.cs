using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseApp.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Worker> Workers { get; set; } = new List<Worker>();
    }
}
