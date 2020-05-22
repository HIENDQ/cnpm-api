using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cnpm_api.Services;
using Microsoft.AspNetCore.Mvc;
using timtro.Models;
using timtro.Services;

namespace timtro.Controller
{
    [ApiController]
    [Route("controller")]
    public class AdminController : ControllerBase
    {
        private IAdminService _service;

        public AdminController(IAdminService service)
        {
            _service = service;
        }


        [HttpGet("/api/admin")]
        public ActionResult<List<Admin>> GetAdmins()
        {
            return _service.GetAdmins();
        }

        [HttpPost("/api/admin")]
        public ActionResult<Boolean> AddAdmin(Admin admin)
        {
            
            return _service.AddAdmin(admin) ;
        }

        [HttpPut("/api/admin/{id}")]
        public ActionResult<Boolean> UpdateAdmin(int id,Admin admin)
        {
            admin.AdminId = id;
            return _service.UpdateAdmin(admin);
        }

        [HttpDelete("/api/admin/{id}")]
        public ActionResult<Boolean> DeleteAdmin(int id)
        {
            return _service.DeleteAdmin(id);
        }
    }
}