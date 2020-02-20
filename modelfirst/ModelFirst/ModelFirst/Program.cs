using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
      static  ModelFirstEntityContainer mfec = new ModelFirstEntityContainer();
        static void Main(string[] args)
        {
            insertproductdata();
           // insetcategorydata();
          //  showcat();
           // showpro();
        }

        private static void showpro()
        {
            Console.WriteLine("............product details.............");
            var product = mfec.Products;
            foreach (var x in product)
            {
                Console.WriteLine("{0} {1} {2} {3}", x.PId, x.Pname, x.Pprice, x.Cid);
            }
        }

        private static void showcat()
        {
            Console.WriteLine("............category details.............");
            var category = mfec.Categories;
            foreach (var x in category)
            {
                Console.WriteLine("{0} {1}", x.Cid, x.Ctitle);
            }
        }

        private static void insetcategorydata()
        {
            Console.WriteLine("enter category name");
            string Ctitle = Console.ReadLine();
            var category = new Category
            {
                Ctitle = Ctitle,

            };
            mfec.Categories.Add(category);
            mfec.SaveChanges();
            Console.WriteLine("inserted  category details succssfully");
        }

        private static void insertproductdata()
        {
            Console.WriteLine("enter product name");
            string Pname = Console.ReadLine();
            Console.WriteLine("enter product price");
            double Pprice = double.Parse(Console.ReadLine());
            Console.WriteLine("enter category id");
            int Cid = int.Parse(Console.ReadLine());
            var product = new Product
            {
                Pname = Pname,
                Pprice = Pprice,
                Cid = Cid
            };
            mfec.Products.Add(product);
            mfec.SaveChanges();
            Console.WriteLine("inserted product details succssfully");
        }
    }
}
