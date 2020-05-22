using System;
using System.Collections.Generic;
using System.Linq;
using cnpm_api.Services.Interfices;
using timtro.Models;

namespace cnpm_api.Services
{
    public class PermissionService : IPermissionService
    {
        private DataContext _context;
        public PermissionService (DataContext context)
        {
            _context=context;
        }
        
        public List<Permission> GetPermissions()
        {
             return _context.Permissions.ToList();
        }
        public Permission GetPermissionById(int id)
        {
            return _context.Permissions.FirstOrDefault(x=> x.PermissionId==id);
        }

        public bool AddPermission(Permission permission)
        {
            try
           {
            permission.DateCreate=DateTime.Now;
            _context.Add(permission);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool DeletePermission(int id)
        {
            try
            {
                _context.Permissions.Remove(GetPermissionById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


        

        public bool  UpdatePermission(Permission permission)
        {
            try
            {
            var permission1 = _context.Permissions.FirstOrDefault(x=> x.PermissionId == permission.PermissionId);
            permission1.PermissionName= permission.PermissionName;
            permission1.DateUpdate=DateTime.Now;
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