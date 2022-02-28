using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entitys
{
    public  class Movie
    {


        [Key]
        [StringLength(50)]
        public string IdMovie { set; get; }

        [Required]
        [StringLength(60)]
        public string Title { set; get; }

        [Required]
        public string Date { set; get; }

        [Required]
        public int Qualification{ set; get; }

        [Required]
        [StringLength(500)]
        public string History { set; get; }

        public ICollection<Characters> Character { set; get; }



    }
}
