using Application.Asteroids.Repositories;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace NasaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsteroidsController : ControllerBase
    {       
        private readonly ILogger<AsteroidsController> _logger;
        private readonly IRepository _repository;

        public AsteroidsController(ILogger<AsteroidsController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;

        }

        [HttpGet(Name = "Get")]
        public async Task<ActionResult<Asteroid>> GetAsteroids([FromQuery] int? days)
        {
            //TODO: RETURN Asteroid from Nasa API
            try
            {

                return await _repository.GetAsteroidAsync(days);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}