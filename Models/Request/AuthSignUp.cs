using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace timtro.Models
{
    [Table("User")]
    public class AuthSignUp
    {
        public string UserName { get; set; }
        public string Password { get; set; }
       public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}