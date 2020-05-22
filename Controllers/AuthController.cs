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
    public class UserLoginController : ControllerBase
    {
        private IUserLoginService _service;

        public UserLoginController(IUserLoginService service)
        {
            _service = service;
        }


        [HttpPost("/api/userlogin")]
        public ActionResult<Boolean> UserLogin(string username, string password)
        {
            return _service.UserLogin(username,password);
        }


    }
}