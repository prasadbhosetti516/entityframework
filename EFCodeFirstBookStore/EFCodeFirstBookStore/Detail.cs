using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstBookStore
{
    class Detail
    {
        [Key]
        public int Tid { get; set; }
        public DateTime PublishDate { get; set; }
       
        public virtual Book books { get; set; }
        public virtual Author authors { get; set; }
    }
}
