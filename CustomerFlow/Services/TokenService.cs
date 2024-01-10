using CustomerFlow.Model;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace CustomerFlow.Services
{
    public class TokenService
    {
        public static object GenerateToken (Customer customer)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[] {
                       new Claim ("customerId", customer.id.ToString()),
                }),
            }
        }
    }
}
