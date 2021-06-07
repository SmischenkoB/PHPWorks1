using DataBaseApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataBaseApp.Services
{
    public class DepartmentService
    {
        public void AddDepartmnet(string Departmentname)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var department = new Department() { DepartmentName = Departmentname };
                db.Departments.Add(department);
                db.SaveChanges();
            }
        }

        public List<string> GetDepartmentsName()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Departments.Select(i => i.DepartmentName).ToList();
            }
        }

        public List<string> GetWorkersByDepartmentName(string departmentName) 
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Departments
                    .Include(i => i.Workers)
                    .FirstOrDefault(i => i.DepartmentName == departmentName)?
                    .Workers.Select(i => i.Name).ToList();
            }
        }
    }
}
