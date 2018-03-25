using System.Threading.Tasks;
using api.roomrental.Entities;
using api.roomrental.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace api.roomrental.Services
{
    public class AuthService : IAuthService
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public AuthService(UserManager<ApplicationUser> userManager,
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

            return result;
        }
    }
}
