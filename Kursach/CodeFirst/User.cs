using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.CodeFirst
{
    internal class User
    {
        [Key]
        public int UserID { get; set; }
        [MinLength(5)]
        [MaxLength(25)]
        public string UserName { get; set; }
        [MinLength(5)]
        [MaxLength(25)]
        public string Password { get; set; }
        public string Role { get; set; } 
    }
}
