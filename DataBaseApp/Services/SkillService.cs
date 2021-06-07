using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataBaseApp.Services
{
    public class SkillService
    {
        public List<string> GetSkills()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Skills.Select(i => i.Name).ToList(); 
            }
        }

        public void AddSkill(string name)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Skills.Add(new Entities.Skill() { Name = name.ToLower() });
                db.SaveChanges();
            }
        }       
        
        public List<string> GetUsersBySkills(string skillName)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
               return db.Skills.Include(j => j.Workers)
                    .FirstOrDefault(i => i.Name == skillName)?
                    .Workers.Select(i => i.Name).ToList();
            }
        }
    }
}
