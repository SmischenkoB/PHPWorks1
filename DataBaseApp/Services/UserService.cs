using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataBaseApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataBaseApp.Services
{
    public class UserService
    {
        public void AddSkillToWorker(string WorkerName, string skill)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var item = db.Skills.FirstOrDefault(i => i.Name == skill.ToLower());
                var worker = db.Workers.FirstOrDefault(i => i.Name == WorkerName);
                worker.Skills.Add(item);
                //item.Workers.Add(worker);
                db.SaveChanges();
            }
        }

        public void AddWorker(string Name, string Department)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var worker = new Worker() { Name = Name };
                var department = db.Departments.First(i => i.DepartmentName == Department);               
                worker.Department = department;
                department.Workers.Add(worker);
                db.SaveChanges();
            }
        }

        public void AddDepartmentToWorker(string workerName, string DepartmentName)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var department = db.Departments.First(i => i.DepartmentName == DepartmentName);
                var worker = db.Workers.First(i => i.Name == workerName);
                worker.Department = department;
                department.Workers.Add(worker);
                db.SaveChanges();
            }
        }

        public List<string> GetWorkerNames()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Workers.Select(i => i.Name).ToList();
            }
        }

        public List<string> GetSkillsByUser(string name)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Workers.
                    Include(i => i.Skills).
                    FirstOrDefault(i => i.Name == name)
                    .Skills.Select(j => j.Name).ToList();
            }
        }

        public string GetDepartmentByName(string name)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Workers
                    .Include(i => i.Department)
                    .FirstOrDefault(i => i.Name == name)?
                    .Department.DepartmentName;
            }
        }
    }
}
