using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.roomrental.Helpers;
using api.roomrental.Models;
using api.roomrental.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.roomrental.controllers
{
    [Produces("application/json")]
    [Route("api/account")]
    public class AccountController : Controller
    {

        private readonly IAccountService _auth;
        public AccountController(IAccountService auth)
        {
            _auth = auth;
            
        }

        // TODO
        [Route("signup")]
        [HttpPost()]
        public async Task<IActionResult> SignupAsync([FromBody] UserRegistrationDAO userDao)
        {
           
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var registerResult = await _auth.CreateUserAsync(userDao);
            if (registerResult.Succeeded)
            {

                return Ok();
            }
            return BadRequest(Errors.AddErrorsToModelState(registerResult, ModelState));
        }


    }
}