using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhpLab1.Pages
{
    public class SkillsModel : PageModel
    {
        public SkillService skillService { get; set; }
        public UserService userService { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SkillName { get; set; } = "";

        public SkillsModel()
        {
            skillService = new SkillService();
            userService = new UserService();
        }
        public void OnGet()
        {
        }

    }
}
