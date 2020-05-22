using System;
using System.Collections.Generic;
using System.Linq;
using timtro.Models;

namespace cnpm_api.Services
{
    public class AdminService : IAdminService
    {
        private DataContext _context;
        public AdminService (DataContext context)
        {
            _context=context;
        }
        
        public List<Admin> GetAdmins()
        {
             return _context.Admins.ToList();
        }
        public Admin GetAdminById(int id)
        {
            return _context.Admins.FirstOrDefault(x=> x.AdminId==id);
        }

        public bool AddAdmin(Admin admin)
        {
            try
           {
            admin.DateCreate=DateTime.Now;
            _context.Add(admin);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool DeleteAdmin(int id)
        {
            try
            {
                _context.Admins.Remove(GetAdminById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


        

        public bool UpdateAdmin(Admin admin)
        {
            try
            {
            var admin1 = _context.Admins.FirstOrDefault(x=> x.AdminId == admin.AdminId);
            admin1.UserName= admin.UserName;
            admin1.Password= admin.Password;
            admin1.Name=admin.Name;
            admin1.Email=admin.Email;
            admin1.DateUpdate=DateTime.Now;
            _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

    }
}