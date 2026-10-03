using WeatherConsoleClient.Application.DTOs;

namespace WeatherConsoleAPI.Application.Interfaces;

public interface IWeatherFormatter
{
    string FormatCurrentWeather(
        CurrentWeatherDto weather,
        bool useFahrenheit);

    string FormatForecast(
        ForecastDto forecast);
}