using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            _logger.LogInformation("Starting GetWeatherForecast request");

            _logger.LogInformation("Beginning weather forecast processing with delay");
            await Task.Delay(300000); // Espera 2 segundos
            _logger.LogInformation("Completed weather forecast processing delay");

            var forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            _logger.LogInformation("Generated {ForecastCount} weather forecast entries", forecast.Length);
            _logger.LogInformation("Completing GetWeatherForecast request");

            return forecast;
        }
        
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            _logger.LogInformation("Starting Hello request");
            
            var response = "Hello from WeatherForecastController!";
            _logger.LogInformation("Generated greeting response: {Response}", response);
            
            _logger.LogInformation("Completing Hello request");
            return Ok(response);
        }

        /*[HttpGet(Name = "Test")]
        public IEnumerable<WeatherForecast> Test()
        {

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }*/
    }
}
