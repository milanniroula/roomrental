using api.roomrental.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace api.roomrental.Services
{
    public interface IAuthService
    {
       Task<IdentityResult> CreateUserAsync(UserRegistrationDAO userDao);
    }
}
