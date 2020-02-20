using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework3
{
    class StoreContext:DbContext
    {
       public DbSet<Customer> customers { get; set; }
       public DbSet<Product> products { get; set; }
    }
}
