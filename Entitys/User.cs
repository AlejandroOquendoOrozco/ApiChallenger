using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entitys
{
   public class User
    {
        
        [Key]
        [StringLength(50)]
        public string IdUser { set; get; }
        [Required]
        [StringLength(60)]
        public  string Name { set; get; }
        [Required]
        [StringLength(80)]
        [EmailAddress]
        public string Email { set; get; }

        [Required]
        [StringLength(80)]
       
        public string Password { set; get; }
    }
}
