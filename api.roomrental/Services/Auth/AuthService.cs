using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using api.roomrental.Entities;
using api.roomrental.Models.viewmodels;
using api.roomrental.Servcices.Jwt;
using Microsoft.AspNetCore.Identity;

namespace api.roomrental.Services.Auth
{
    public class AuthService : IAuthService
    {

        private UserManager<AppUser> _userManager { get; set; }
        private IJwtService _jwtService { get; set; }


        public AuthService(UserManager<AppUser> userManager, IJwtService jwtService)
        {

            _userManager = userManager;
            _jwtService = jwtService;

        }


        public async Task<ClaimsIdentity> AuthenticateUser(LoginViewModel model)
        {

            if (String.IsNullOrWhiteSpace(model.Email) || String.IsNullOrWhiteSpace(model.Password))
                return await Task.FromResult<ClaimsIdentity>(null);

            var userToverify = await _userManager.FindByEmailAsync(model.Email);

            if (userToverify == null)
                return await Task.FromResult<ClaimsIdentity>(null);

            var isValidCredential = await _userManager.CheckPasswordAsync(userToverify, model.Password);

            if (!isValidCredential)
                return await Task.FromResult<ClaimsIdentity>(null);

            var roles = await _userManager.GetRolesAsync(userToverify);
            var identity = await GetClaimsIdentity(model.Email, userToverify.Id, roles);

            return await Task.FromResult<ClaimsIdentity>(identity);
        }


        private async Task<ClaimsIdentity> GetClaimsIdentity(string email, string id, IList<string> roles)
        {
            return await Task.FromResult(_jwtService.GenerateClaimsIdentity(email, id, roles));

        }
    }
}
