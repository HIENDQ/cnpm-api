using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace timtro.Models
{
    [Table("News")]
    public class News
    {
        [Key]
        public int NewsId { get; set; }  
        public string Title  { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public float Area { get; set; }
        public string Address { get; set; }
        public string Picture { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User Users { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}