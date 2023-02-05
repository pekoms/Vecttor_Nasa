

using Application.Asteroids.Repositories;

namespace Domain.UnitTest
{
    public class Tests
    {
        private AsteroidRepository _asteroidRepository;

        [SetUp]
        public void Setup()
        {
            _asteroidRepository = new AsteroidRepository();
        }

        [Test]
        public void Is_Asteroid_Given()
        {
            var day = 3;

            var result = _asteroidRepository.GetAsteroidAsync(day);
            
            Assert.Pass();
        }
    }
}