using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace timtro.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; } 
        public string CommentDetail { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("New")]
        public int  NewId { get; set; }
        public User Users { get; set; }
        public New News { get; set; }

        
    }
}