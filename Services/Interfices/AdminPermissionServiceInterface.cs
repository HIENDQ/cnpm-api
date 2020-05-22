using System.Collections.Generic;
using timtro.Models;

namespace cnpm_api.Services.Interfices
{
    public interface IAdminPermissionService
    {
        public List<AdminPermission> GetAdminPermissions();
        public AdminPermission GetAdminPermissionById(int id);

        public bool AddAdminPermission(AdminPermission adminPermission);

        public bool UpdateAdminPermission(AdminPermission adminPermission);

        public bool DeleteAdminPermission(int id);
         
    }
}