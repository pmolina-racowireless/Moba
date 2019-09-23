using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MobaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeagueController : ControllerBase
    {
        private readonly ILogger<LeagueController> _logger;

        public LeagueController(ILogger<LeagueController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var json = System.IO.File.ReadAllText(@"../MobaShared/Data/Leagues.json");
            return json;
        }
    }
}
