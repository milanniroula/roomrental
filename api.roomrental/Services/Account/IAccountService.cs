using api.roomrental.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace api.roomrental.Services
{
    public interface IAccountService
    {
       Task<IdentityResult> CreateUserAsync(UserRegistrationDAO userDao);

    }
}
