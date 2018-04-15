using api.roomrental.Entities;
using api.roomrental.Helpers;
using api.roomrental.Models;
using api.roomrental.Models.viewmodels;
using api.roomrental.Servcices.Jwt;
using api.roomrental.Services.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace api.roomrental.controllers
{
    [Produces("application/json")]
    [Route("api/auth")]
    public class AuthController : Controller
    {

        private UserManager<ApplicationUser> _userManager { get; set; }
        private IAuthService _auth { get; set; }
        private JwtIssuerOptions _jwtOptions { get; set; }
        private IJwtService _jwtService { get; set; }

        public AuthController(IAuthService auth, IOptions<JwtIssuerOptions> jwtOptions, IJwtService jwtService)
        {
            _auth = auth;
            _jwtOptions = jwtOptions.Value;
            _jwtService = jwtService;
        }

        [Route("login")]
        [HttpPost()]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var identity = await _auth.AuthenticateUser(model);

            if (identity == null)
                return BadRequest(Errors.AddErrorToModelState("error", "Invalid username or password.", ModelState));

            var jwt = await Tokens.GenerateJwt(identity, _jwtService, model.Email, _jwtOptions, new JsonSerializerSettings { Formatting = Formatting.None });

            return new OkObjectResult(jwt);
        }
    }
}