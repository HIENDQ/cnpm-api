using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace timtro.Models
{
    [Table("AdminPermission")]
    public class AdminPermission
    {
        [Key]
        public int AdminPermissionId { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        [ForeignKey("Permission")]
        public int PermissionId { get; set; }
        public bool license { get; set; }
        public Admin Admins { get; set; }
        public Permission Permissions { get; set; }

        
    }
}