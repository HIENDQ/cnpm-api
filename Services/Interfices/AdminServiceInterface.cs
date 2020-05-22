using System.Collections.Generic;
using timtro.Models;

namespace cnpm_api.Services
{
    public interface IAdminService
    {
        public List<Admin> GetAdmins();
        public Admin GetAdminById(int id);

        public bool AddAdmin(Admin admin);

        public bool UpdateAdmin(Admin admin);

        public bool DeleteAdmin(int id);
    }
}