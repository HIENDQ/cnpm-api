using System;
using System.Collections.Generic;
using System.Linq;
using cnpm_api.Services.Interfices;
using timtro.Models;

namespace cnpm_api.Services
{
    public class AdminPermissionService : IAdminPermissionService
    {
        private DataContext _context;
        public AdminPermissionService (DataContext context)
        {
            _context=context;
        }
        
        public List<AdminPermission> GetAdminPermissions()
        {
             return _context.AdminPermissions.ToList();
        }
        public AdminPermission GetAdminPermissionById(int id)
        {
            return _context.AdminPermissions.FirstOrDefault(x=> x.AdminPermissionId==id);
        }

        public bool AddAdminPermission(AdminPermission adminPermission)
        {
            try
           {
            adminPermission.DateCreate=DateTime.Now;
            _context.Add(adminPermission);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool DeleteAdminPermission(int id)
        {
            try
            {
                _context.AdminPermissions.Remove(GetAdminPermissionById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


        

        public bool  UpdateAdminPermission(AdminPermission adminPermission)
        {
            try
            {
            var adminPermission1 = _context.AdminPermissions.FirstOrDefault(x=> x.AdminPermissionId == adminPermission.AdminPermissionId);
            adminPermission1.license= adminPermission.license;
            adminPermission1.Admins= adminPermission.Admins;
            adminPermission1.Permissions=adminPermission.Permissions;
            adminPermission1.DateUpdate=DateTime.Now;
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