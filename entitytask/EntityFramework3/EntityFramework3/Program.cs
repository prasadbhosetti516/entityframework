using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //insertCustomer();
            StoreContext sc = new StoreContext();
            sc.products
            List<Product> plist = new List<Product>();
            Console.WriteLine("Enter Pname");
            string pname = Console.ReadLine();
            plist.Add(new Product { Pname = pname });
            
        }

        private static void insertCustomer()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            StoreContext sc = new StoreContext();
            sc.customers.Add(new Customer { Cname = name });
            sc.products.To List<Product> 
            
        }
    }
}
