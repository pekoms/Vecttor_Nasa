using Domain;
using NasaAPI.Models.Asteroids;

namespace Application.Asteroids.Repositories
{
    public interface IRepository
    {
       public Task<Asteroid> GetAsteroidAsync(int? days);
    }
}