using System.Diagnostics;
using Dev.App;
using Dev.Core;
using Microsoft.AspNetCore.Mvc;

namespace Dev.Host.Controllers;

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
    public int Get()
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "D:\\JiaGuangli\\Soft\\phpstudy_pro\\COM\\phpstudy_pro.exe", // 这里替换为你想启动的程序
            Arguments = "", // 如果有参数，可以在这里添加
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        return ProcessHelper.Run(startInfo);
    }
}