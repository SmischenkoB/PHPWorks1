using DataBaseApp.Entities;
using System;
using System.Linq;

namespace DataBaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                var user1 = new Department { DepartmentName = "First" };
                var user2 = new Department { DepartmentName = "Second" };

                // добавляем их в бд
                db.Departments.Add(user1);
                db.Departments.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Departments.ToList();
                Console.WriteLine("Список объектов:");
                foreach (var u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.DepartmentName}");
                }
            }
            Console.Read();
            Console.WriteLine("Hello World!");
        }
    }
}
