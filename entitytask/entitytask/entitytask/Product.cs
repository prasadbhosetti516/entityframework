using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitytask
{
    class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        [Required]
        public int Pprice{ get; set; }
        [MaxLength(250)]
        public virtual ICollection<Purchase> purchases { get; set; }

    }
}
