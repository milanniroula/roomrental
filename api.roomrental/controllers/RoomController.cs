using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.roomrental.controllers
{
    [Produces("application/json")]
    [Route("api/rooms")]
    public class RoomController : Controller
    {
        private ILogger<RoomController> _logger;

        public RoomController(ILogger<RoomController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult GetRooms()
        {

            var rooms = new[] { new { name = "Sydney" }, new { name = "Brisbane" } };
            _logger.LogInformation("logggin information");
            return Ok(rooms);
        }

    }
}