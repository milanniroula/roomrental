using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace api.roomrental.controllers
{
    [Produces("application/json")]
    [Route("api/auth")]
    public class AuthController : Controller
    {

        [Route("login")]
        [HttpPost()]
        public async Task<IActionResult> login()
        {


        }
    }
}