using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstTask
{
    class Program
    {
        static prasadEntities pe = new prasadEntities();
        static void Main(string[] args)
        {
            insertcategory();
            insertproduct();
            showproduct();
            showcategory();
        }

        private static void showcategory()
        {
            Console.WriteLine("category details are:");
            var categories = pe.Categories;
            Console.WriteLine("{0,-8}{1,-14}", "cid", "cname");
            foreach (var l in categories)
            {
                Console.WriteLine("{0,-8}{1,-14}", l.Cid, l.Cname);
            }
        }

        private static void showproduct()
        {
            Console.WriteLine("product details are:");
            var products = pe.Products;
            Console.WriteLine("{0,-8}{1,-14}{2,-14}{3,-8}{4,-14}", "pid", "pname", "price", "cid", "cname");
            foreach (var d in products)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-14}{3,-8}{4,-14}", d.Pid, d.Ptitle, d.Pprice, d.Cid, d.Category.Cname);
            }
        }

        private static void insertproduct()
        {
            Console.WriteLine("************ product details are************");
            Console.WriteLine("enter product id");
            int pid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter product title");
            string title = Console.ReadLine();

            Console.WriteLine("enter price");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("enter category id");
            int cid = int.Parse(Console.ReadLine());


            Console.WriteLine(".....................inserted sucesfully....................");

            var products = new Product
            {
                Pid = pid,
                Ptitle = title,
                Pprice = price,
                Cid = cid
            };
            pe.Products.Add(products);
            pe.SaveChanges();
        }

        private static void insertcategory()
        {
            Console.WriteLine("************ category details are************");
            Console.WriteLine("enter category id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Category name");
            string name = Console.ReadLine();
            Console.WriteLine(".....................inserted sucesfully....................");

            var Category = new Category
            {
                Cid = id,
                Cname = name
            };
            pe.Categories.Add(Category);
            pe.SaveChanges();
        }
    }
}