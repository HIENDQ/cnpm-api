using System;
using System.Collections.Generic;
using System.Linq;
using cnpm_api.Services.Interfices;
using timtro.Models;

namespace cnpm_api.Services
{
    public class PermissionDetailService : IPermissionDetailService
    {
        private DataContext _context;
        public PermissionDetailService (DataContext context)
        {
            _context=context;
        }
        
        public List<PermissionDetail> GetPermissionDetails()
        {
             return _context.PermissionDetails.ToList();
        }
        public PermissionDetail GetPermissionDetailById(int id)
        {
            return _context.PermissionDetails.FirstOrDefault(x=> x.PermissionDetailId==id);
        }

        public bool AddPermissionDetail(PermissionDetail permissionDetail)
        {
            try
           {
            permissionDetail.DateCreate=DateTime.Now;
            _context.Add(permissionDetail);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool DeletePermissionDetail(int id)
        {
            try
            {
                _context.PermissionDetails.Remove(GetPermissionDetailById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


        

        public bool  UpdatePermissionDetail(PermissionDetail permissionDetail)
        {
            try
            {
            var permissionDetail1 = _context.PermissionDetails.FirstOrDefault(x=> x.PermissionDetailId == permissionDetail.PermissionDetailId);
            permissionDetail1.ActionName= permissionDetail.ActionName;
            permissionDetail1.CheckAction= permissionDetail.CheckAction;
            permissionDetail1.Permissions= permissionDetail.Permissions;
            permissionDetail1.DateUpdate=DateTime.Now;
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