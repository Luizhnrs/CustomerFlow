using CustomerFlow.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CustomerFlow.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if(username == "Luiz" && password == "11072001") 
            {
                var token = TokenService.GenerateToken(new Model.Customer());
                return Ok(token);
            }

            return BadRequest("Auth Is Invalid");
        }
    }
}
