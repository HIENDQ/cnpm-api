using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace timtro.Models
{
    [Table("Permission")]
    public class Permission
    {
        [Key]
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public ICollection<AdminPermission> AdminPermissions { get; set; }
        public ICollection<PermissionDetail> PermissionDetails { get; set; }

    }
}