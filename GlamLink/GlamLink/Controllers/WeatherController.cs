using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly string apiKey = "c261a33fc8444cf5bc7154903252605"; 
    public WeatherController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    [HttpGet("{city}/{date}")]
    public async Task<IActionResult> GetWeatherForDate(string city, DateTime date)
    {
        if (date.Date < DateTime.Today || date.Date > DateTime.Today.AddDays(14))
        {
            return BadRequest("Forecast available only for the next 14 days.");
        }

        string formattedDate = date.ToString("yyyy-MM-dd");
        string apiUrl = $"https://api.weatherapi.com/v1/forecast.json?key={apiKey}&q={city}&dt={formattedDate}";

        try
        {
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var forecast = JsonDocument.Parse(content);

            var day = forecast.RootElement
                .GetProperty("forecast")
                .GetProperty("forecastday")[0]
                .GetProperty("day");

            var result = new
            {
                Date = formattedDate,
                TemperatureC = (int)Math.Round(day.GetProperty("avgtemp_c").GetDouble()),
                Summary = day.GetProperty("condition").GetProperty("text").GetString(),
                IconUrl = "https:" + day.GetProperty("condition").GetProperty("icon").GetString()
            };

            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Weather API error: {ex.Message}");
        }
    }
}
