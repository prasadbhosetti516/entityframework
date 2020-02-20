﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstBookStore
{
    class Book
    {
        [Key]
        public int Bid { get; set; }
        public string Btitle { get; set; }
        public double Bprice { get; set; }
        public virtual ICollection<Author> authors { get; set; }
        public int Aid { get; set; }

    }
}
