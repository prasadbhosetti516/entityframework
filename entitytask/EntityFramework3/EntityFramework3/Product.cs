using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework3
{
    class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
    }
}
