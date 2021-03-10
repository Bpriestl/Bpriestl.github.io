using BuonkuangPriestleyPortfolio.Models;
using BuonkuangPriestleyPortfolio.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuonkuangPriestleyPortfolio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        //constructor
        public ProjectController(JsonFileProjectService projectService)
        {
            this.ProjectService = projectService;
        }
        public JsonFileProjectService ProjectService { get; }

        
        //HttpGet retrieves data from server to client
        //HttpPost makes a new thing in database
        //HttpPut updates something in database
        //HttpPatch updating a portion of the database 
        //[HttpPatch] "[FromBody]"
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return ProjectService.GetProjects();
        }

    }
}
