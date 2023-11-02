using ChatWebApi_01.ApiDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatWebApi_01.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginApiController : ControllerBase
    {
        public IActionResult Login(LoginDTO login)
        {
            
            return View();
        }
    }
}
