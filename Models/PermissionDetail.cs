using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace timtro.Models
{
    [Table("PermissionDetail")]
    public class PermissionDetail
    {
        [Key]
        public int PermissionDetailId { get; set; }

        [ForeignKey("Permission")]
        public int PermissionId { get; set; }
        public string ActionName { get; set; }
        public bool CheckAction { get; set; }
        public Permission Permissions { get; set; }

    }
}