using Domain;
using NasaAPI.Models.Asteroids;

namespace Application.Asteroids.Repositories
{
    public interface IRepository
    {
        Task<Asteroid> GetAsteroidAsync(int? days);
    }
}