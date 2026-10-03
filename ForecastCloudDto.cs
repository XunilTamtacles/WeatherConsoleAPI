
using System.Text.Json.Serialization;

namespace WeatherConsoleClient.Application.DTOs;

public class ForecastCloudDto
{
    [JsonPropertyName("all")]
    public int Percentage { get; set; }
}