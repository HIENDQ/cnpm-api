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
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }


        [HttpGet("/api/user")]
        public ActionResult<List<User>> GetUsers()
        {
            return _service.GetUsers();
        }

        [HttpPost("/api/user")]
        public ActionResult<Boolean> AddUser(User user)
        {
            
            return _service.AddUser(user) ;
        }

        [HttpPut("/api/user/{id}")]
        public ActionResult<Boolean> UpdateUser(int id,User user)
        {
            user.UserId = id;
            return _service.UpdateUser(user);
        }

        [HttpDelete("/api/user/{id}")]
        public ActionResult<Boolean> DeleteUser(int id)
        {
            return _service.DeleteUser(id);
        }
    }
}