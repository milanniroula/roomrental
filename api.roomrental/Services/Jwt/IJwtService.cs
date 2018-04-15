
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace api.roomrental.Servcices.Jwt
{
    public interface IJwtService
    {
        Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id, IList<string> roles);
    }
}