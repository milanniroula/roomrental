using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.roomrental.Entities;
using api.roomrental.Helpers;
using api.roomrental.Models;
using api.roomrental.Models.viewmodels;
using api.roomrental.Services;
using api.roomrental.Services.Message;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.roomrental.controllers
{
    [Produces("application/json")]
    [Route("api/account")]
    public class AccountController : Controller
    {

        private readonly IAccountService _auth;
        private readonly UserManager<ApplicationUser>  _userManager;
        private readonly IEmailSender _messageService;

        public AccountController(IAccountService auth, UserManager<ApplicationUser> userManager, IEmailSender messageService)
        {
            _auth = auth;
            _userManager = userManager;
            _messageService = messageService;


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

        [Route("forgotpassword")]
        [HttpPost()]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user == null)
                    return Ok();

                string code = await _userManager.GeneratePasswordResetTokenAsync(user);
                await _messageService.SendEmailAsync(model.Email, "test", "Hello");
                return Ok(new { code = code });
            }

            return BadRequest( ModelState);



        }


    }
}