

using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using api.roomrental.Models;
using api.roomrental.Servcices.Jwt;
using Newtonsoft.Json;

namespace api.roomrental.Helpers
{
    public class Tokens
    {
        public static async Task<string> GenerateJwt(ClaimsIdentity identity, IJwtService jwtService, string userName, JwtIssuerOptions jwtOptions, JsonSerializerSettings serializerSettings)
        {
            var response = new
            {
                id = identity.Claims.Single(c => c.Type == ClaimTypes.NameIdentifier).Value,
                auth_token = await jwtService.GenerateEncodedToken(userName, identity),
                expires_in = (int)jwtOptions.ValidFor.TotalSeconds
            };

            return JsonConvert.SerializeObject(response, serializerSettings);
        }
    }
}