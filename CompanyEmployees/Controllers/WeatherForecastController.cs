using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private readonly ILoggerManager _logger;

        //public WeatherForecastController(ILoggerManager logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    _logger.LogInfo("Info msg from our values controller");
        //    _logger.LogDebug("Info debug from our values controller");
        //    _logger.LogWarn("Info warn from our values controller");
        //    _logger.LogError("Info error from our values controller");

        //    return new string[] { "Value1", "Value2" };
        //}

        private IRepositoryManager _repository;

        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _repository.Company.ToString();
            _repository.Company.ToString();

            return new string[] { "Value1", "Value2" };
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
