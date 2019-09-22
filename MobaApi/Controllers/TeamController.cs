using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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

        [Authorize]
        [HttpGet]
        [EnableCors]
        public string Get()
        {
            var json = System.IO.File.ReadAllText(@"../MobaShared/Data/Teams.json");
            return json;
        }
    }
}
