using BuonkuangPriestleyPortfolio.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BuonkuangPriestleyPortfolio.Services
{
    public class JsonFileProjectService
    {
        public JsonFileProjectService(IWebHostEnvironment webHostEnvironment) //allows to geth path of json file
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; } //retrieves the json file
        
        private string JsonFileName //gets the path name of the json file
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "projects.json"); }
        }

        public IEnumerable<Project> GetProjects()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

    }
}
