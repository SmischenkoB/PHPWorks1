using DataBaseApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhpLab1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public UserService userService { get; set; }
        public DepartmentService departmentService { get; set; }
        public SkillService skillService { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            userService = new UserService();
            departmentService = new DepartmentService();
            skillService = new SkillService();
            //departmentService.AddDepartmnet("Amazon");
            //skillService.AddSkill("English Advanced");
            //skillService.AddSkill("English Upper-Intermediate");
            //skillService.AddSkill("English Intermediate");
            //skillService.AddSkill("English Elementary");
            //skillService.AddSkill(".Net");
            //skillService.AddSkill("Java");
            //skillService.AddSkill("C++");
            //userService.AddSkillToWorker("Ibragim", ".Net");
            //userService.AddWorker("Eric", "Google");
            //userService.AddSkillToWorker("Ibragim", ".Net");
            //userService.AddSkillToWorker("Ibragim", "Java");
            //userService.AddSkillToWorker("Eric", "Java");
            //userService.AddSkillToWorker("Eric", "English Advanced");

        }

        public void OnGet()
        {

        }
    }
}
