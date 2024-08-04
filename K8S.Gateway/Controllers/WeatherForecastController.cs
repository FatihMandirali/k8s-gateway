using Microsoft.AspNetCore.Mvc;

namespace K8S.Gateway.Controllers;

[ApiController]
[Route("test")]
public class WeatherForecastController(ApplicationDbContext _context) : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Fatih Talha Mandıralı";
    }
    [HttpGet("List")]
    public IEnumerable<SampleData> GetList()
    {
        return _context.SampleData.ToList();
    }

    [HttpPost]
    public IActionResult Post(SampleData sampleData)
    {
        _context.SampleData.Add(sampleData);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = sampleData.Id }, sampleData);
    }
}