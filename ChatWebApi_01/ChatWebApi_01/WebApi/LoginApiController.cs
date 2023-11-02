using ChatWebApi_01.ApiDTO;
using ChatWebApi_01.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatWebApi_01.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginApiController : ControllerBase
    {
        private readonly LoginLogic _loginLogic;

        public LoginApiController(LoginLogic loginLogic)
        {
            _loginLogic = loginLogic;
        }

        [HttpPost]
        public IActionResult Login(LoginDTO loginData)
        {
            var result = _loginLogic.LoginCheck(loginData);
            return Ok(result);
        }
    }
}
