using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhpLab1.Pages
{
    public class DepartmentModel : PageModel
    {

        public UserService userService { get; set; }
        public DepartmentService departmentService { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DepartmentName { get; set; } = "";

        public DepartmentModel()
        {
            userService = new UserService();
            departmentService = new DepartmentService();
        }
        public void OnGet()
        {
        }
    }
}
