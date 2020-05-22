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
    public class PermissionDetailController : ControllerBase
    {
        private IPermissionDetailService _service;

        public PermissionDetailController(IPermissionDetailService service)
        {
            _service = service;
        }


        [HttpGet("/api/permissionDetail")]
        public ActionResult<List<PermissionDetail>> GetPermissionDetails()
        {
            return _service.GetPermissionDetails();
        }

        [HttpPost("/api/permissionDetail")]
        public ActionResult<Boolean> AddPermissionDetail(PermissionDetail permissionDetail)
        {
            
            return _service.AddPermissionDetail(permissionDetail) ;
        }

        [HttpPut("/api/permissionDetail/{id}")]
        public ActionResult<Boolean> UpdatePermissionDetail(int id,PermissionDetail permissionDetail)
        {
            permissionDetail.PermissionDetailId = id;
            return _service.UpdatePermissionDetail(permissionDetail);
        }

        [HttpDelete("/api/permissionDetail/{id}")]
        public ActionResult<Boolean> DeletePermissionDetail(int id)
        {
            return _service.DeletePermissionDetail(id);
        }
    }
}