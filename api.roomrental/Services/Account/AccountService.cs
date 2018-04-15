using System.Threading.Tasks;
using api.roomrental.Entities;
using api.roomrental.Helpers;
using api.roomrental.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace api.roomrental.Services
{
    public class AccountService: IAccountService
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public AccountService(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }


        public async Task<IdentityResult> CreateUserAsync(UserRegistrationDAO userDao)
        {
            var user = _mapper.Map<ApplicationUser>(userDao);
            var result = await _userManager.CreateAsync(user, userDao.Password);
            if (result.Succeeded)
            {

                var existingUser = _userManager.FindByEmailAsync(userDao.UserName);
                return await _userManager.AddToRoleAsync(user, Constants.Strings.Roles.User);

            }
            return result;
        }
    }
}
