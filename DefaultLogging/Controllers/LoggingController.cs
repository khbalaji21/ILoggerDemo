using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DefaultLogging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggingController : ControllerBase
    {
        private readonly ILogger<LoggingController> _logger;

        public LoggingController(ILogger<LoggingController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Message Logged!!");
            return "Check on the console if a message is logged";
        }
    }
}
