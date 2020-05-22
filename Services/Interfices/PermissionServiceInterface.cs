using System.Collections.Generic;
using timtro.Models;

namespace cnpm_api.Services.Interfices
{
    public interface IPermissionService
    {
         public List<Permission> GetPermissions();
        public Permission GetPermissionById(int id);

        public bool AddPermission(Permission permission);

        public bool UpdatePermission(Permission permission);

        public bool DeletePermission(int id);
    }
}