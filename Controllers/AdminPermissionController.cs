using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cnpm_api.Services;
using cnpm_api.Services.Interfices;
using Microsoft.AspNetCore.Mvc;
using timtro.Models;
using timtro.Services;

namespace timtro.Controller
{
    [ApiController]
    [Route("controller")]
    public class AdminPermissionController : ControllerBase
    {
        private IAdminPermissionService _service;

        public AdminPermissionController(IAdminPermissionService service)
        {
            _service = service;
        }


        [HttpGet("/api/adminpermission")]
        public ActionResult<List<AdminPermission>> GetAdminPermissions()
        {
            return _service.GetAdminPermissions();
        }

        [HttpPost("/api/adminpermission")]
        public ActionResult<Boolean> AddAdminPermission(AdminPermission adminPermission)
        {
            
            return _service.AddAdminPermission(adminPermission) ;
        }

        [HttpPut("/api/adminpermission/{id}")]
        public ActionResult<Boolean> UpdateAdminPermission(int id,AdminPermission adminPermission)
        {
            adminPermission.AdminPermissionId = id;
            return _service.UpdateAdminPermission(adminPermission);
        }

        [HttpDelete("/api/adminpermission/{id}")]
        public ActionResult<Boolean> DeleteAdminPermission(int id)
        {
            return _service.DeleteAdminPermission(id);
        }
    }
}