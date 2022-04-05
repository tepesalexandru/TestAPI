using System;
using System.Collections.Generic;
using System.Linq;
using TestAPI.Repositories;

namespace TestAPI.Business
{
    public interface IWeatherForecastManager
    {
        IEnumerable<WeatherForecast> GetWeather();
    }
    public class WeatherForecastManager: IWeatherForecastManager
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        public WeatherForecastManager(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }
        public IEnumerable<WeatherForecast> GetWeather()
        {
            var rng = new Random();
            var Summaries = _weatherForecastRepository.GetSummaries();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
