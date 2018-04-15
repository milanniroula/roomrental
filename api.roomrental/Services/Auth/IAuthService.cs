using api.roomrental.Models.viewmodels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace api.roomrental.Services.Auth
{
    public interface IAuthService
    {
        Task<ClaimsIdentity> AuthenticateUser(LoginViewModel model);
    }
}
