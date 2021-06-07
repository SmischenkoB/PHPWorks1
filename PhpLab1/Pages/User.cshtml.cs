using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhpLab1.Pages
{
    public class UserModel : PageModel
    {
        public SkillService skillService { get; set; }
        public UserService userService { get; set; }

        [BindProperty(SupportsGet = true)]
        public string UserName { get; set; } = "";
        public UserModel()
        {
            skillService = new SkillService();
            userService = new UserService();
        }
        public void OnGet()
        {

        }
    }
}
