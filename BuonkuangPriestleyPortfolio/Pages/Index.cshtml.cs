using BuonkuangPriestleyPortfolio.Models;
using BuonkuangPriestleyPortfolio.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuonkuangPriestleyPortfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProjectService ProjectService; //class obj
        
        public IEnumerable<Project> Projects //for every item in projects
        {
            get; private set;
        }
        public IndexModel(ILogger<IndexModel> logger, 
            JsonFileProjectService projectService)          // this is just saying 'hey go get this stuff for me'
        {
            _logger = logger;
            ProjectService = projectService;
        }

        public void OnGet()
        {
            Projects = ProjectService.GetProjects();
        }
    }
}
