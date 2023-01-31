using Microsoft.AspNetCore.Mvc;

namespace NasaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsteroidsController : ControllerBase
    {
       

        private readonly ILogger<AsteroidsController> _logger;

        public AsteroidsController(ILogger<AsteroidsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public ActionResult<int> GetAsteroids([FromQuery] int days)
        {
            //TODO: RETURN Asteroid from Nasa API

            return days;
        }
    }
}