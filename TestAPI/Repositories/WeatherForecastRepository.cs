namespace TestAPI.Repositories
{
    public interface IWeatherForecastRepository
    {
        string[] GetSummaries();
    }
    public class WeatherForecastRepository: IWeatherForecastRepository
    {
        private readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string[] GetSummaries()
        {
            return Summaries;
        }
    }
}
