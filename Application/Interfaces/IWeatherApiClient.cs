using WeatherConsoleClient.Application.DTOs;

namespace WeatherConsoleAPI.Application.Interfaces;

public interface IWeatherApiClient
{
    Task<CurrentWeatherDto?> GetCurrentWeatherAsync(
        string city,
        CancellationToken cancellationToken);

    Task<ForecastDto?> GetForecastAsync(
        string city,
        CancellationToken cancellationToken);
}