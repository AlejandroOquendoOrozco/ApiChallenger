using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entitys
{
    public class Gender
    {

        [Key]
        [StringLength(20)]
        public string IdGender { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }


        public ICollection<Movie> Movies { set; get; }
    }
}
