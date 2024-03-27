using Microsoft.AspNetCore.Mvc;

namespace Serverless.Api.Controllers;

[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    private readonly ILogger<ValuesController> _logger;

    public ValuesController(ILogger<ValuesController> logger)
    {
        _logger = logger;
    }

    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInformation("getting all");
        return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        _logger.LogInformation($"Found {id}");
        return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
        _logger.LogInformation(value);
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
        _logger.LogInformation($"{id} - {value}");
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _logger.LogInformation($"{id}");
    }
}