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
    public class PermissionController : ControllerBase
    {
        private IPermissionService _service;

        public PermissionController(IPermissionService service)
        {
            _service = service;
        }


        [HttpGet("/api/permission")]
        public ActionResult<List<Permission>> GetPermissions()
        {
            return _service.GetPermissions();
        }

        [HttpPost("/api/permission")]
        public ActionResult<Boolean> AddPermission(Permission permission)
        {
            
            return _service.AddPermission(permission) ;
        }

        [HttpPut("/api/permission/{id}")]
        public ActionResult<Boolean> UpdatePermission(int id,Permission permission)
        {
            permission.PermissionId = id;
            return _service.UpdatePermission(permission);
        }

        [HttpDelete("/api/permission/{id}")]
        public ActionResult<Boolean> DeletePermission(int id)
        {
            return _service.DeletePermission(id);
        }
    }
}