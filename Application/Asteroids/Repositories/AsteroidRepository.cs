using Domain;
using NasaAPI.Models.Asteroids;
using RestSharp;
using System.Text.Json;

namespace Application.Asteroids.Repositories
{
    public class AsteroidRepository:IRepository
    {
       

        public async Task<Asteroid> GetAsteroidAsync(int? days)
        {
           
                if(days == null) { throw new Exception("El parametro días es obligatorio"); }
                if (days <1 && days > 8) { throw new Exception("Los dias tienen que ser valores entre 1 y 7"); }

            //return await PostAsteroids(days);

            var a = await PostAsteroids(days);
            return new Asteroid();
        }

        private async Task<AsteroidModel> PostAsteroids(int? days)
        {
            var date = DateTime.Now.AddDays((double)days);
           
            var client = new RestClient("https://api.nasa.gov/neo/rest/v1");
            var request = new RestRequest("/feed?start_date=2021-12-09&end_date=2021-12-12&api_key=zdUP8ElJv1cehFM0rsZVSQN7uBVxlDnu4diHlLSb", Method.Get);
            request.AddHeader("Cookie", "JSESSIONID=4A46C5150C8F8CF0B9730A23E6DE956A; __VCAP_ID__=ebc9879c-020c-4bd5-6d64-8be3");
            RestResponse response = await client.ExecuteAsync(request);

            if (response.Content != null)
            {
               var a= JsonSerializer.Deserialize<AsteroidModel>(response.Content);
            }
            

            return new  AsteroidModel();
        }

    }
}
