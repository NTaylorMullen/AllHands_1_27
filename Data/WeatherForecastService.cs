using System;
using System.Threading.Tasks;

namespace AllHands_1_27.Data
{
    public abstract class WeatherForecastService
    {
        public abstract Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
