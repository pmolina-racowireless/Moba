using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;

namespace MobaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ILogger<TeamController> _logger;

        public TeamController(ILogger<TeamController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [EnableCors]
        public string Get()
        {
            var json = System.IO.File.ReadAllText(@"../MobaShared/Data/Teams.json");
            return json;
        }
    }
}
