using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entitys
{
    public class Characters
    {
        [Key]
        [StringLength(50)]

        public string IdCharacters { set; get; }

      

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        [Required]
        public int Age { set; get; }

        [Required]
        public int Weight { set; get; }

        [Required]
        [StringLength(500)]
        public string History { set; get; }


        public ICollection<Movie> Movies { set; get; }

    }
}
