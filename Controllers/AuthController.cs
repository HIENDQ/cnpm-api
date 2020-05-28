using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using timtro.Models;
using timtro.Services;

namespace timtro.Controller
{
    [ApiController]
    [Route("controller")]
    public class AuthController : ControllerBase
    {
        private IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }


        [HttpPost("/api/userlogin")]
        public ActionResult<Boolean> UserLogin(string username, string password)
        {
            return _service.UserLogin(username,password);
        }
        
        [HttpPost("/api/usersignup")]
        public ActionResult<Boolean> UserSignUp(AuthSignUp user)
        {
            var validation = _service.ValidateBeforeSignUp(user);
            if (validation == true)
            {
                return _service.SignUp(user);
            }
            else
            {
                return false;
            }
        }
         
    }
}