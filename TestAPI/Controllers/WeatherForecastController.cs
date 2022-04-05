using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Business;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastManager _weatherForecastManager;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastManager weatherForecastManager)
        {
            _logger = logger;
            _weatherForecastManager = weatherForecastManager;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecastManager.GetWeather();
        }
    }
}
