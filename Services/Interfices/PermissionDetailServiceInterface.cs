using System.Collections.Generic;
using timtro.Models;

namespace cnpm_api.Services.Interfices
{
    public interface IPermissionDetailService
    {
         public List<PermissionDetail> GetPermissionDetails();
        public PermissionDetail GetPermissionDetailById(int id);

        public bool AddPermissionDetail(PermissionDetail permissionDetail);

        public bool UpdatePermissionDetail(PermissionDetail permissionDetail);

        public bool DeletePermissionDetail(int id);
    }
}