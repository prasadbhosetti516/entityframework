using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace entitytask
{
    class Program
    {
        // static CPContext cp = new CPContext();

        static void Main(string[] args)
        {
            showall();
          //  Insert();
            // search();
            // delete();
        }/*

        private static void delete()
        {
            Console.WriteLine("enter id to deldete");
            int id = int.Parse(Console.ReadLine());
            var cus = cp.Customers;
            var cus2 = from e in cus
                       where e.Cid == id
                       select e;
            cp.Customers.RemoveRange(cus2);
            foreach (var res in cus2)
            {
                Console.WriteLine("{0} {1} {2} {3}", res.Cid, res.Cname, res.Caddr);

            }
            cp.SaveChanges();
        }

        private static void search()
        {
            Console.WriteLine("enetr id to search");
            int Cid = int.Parse(Console.ReadLine());
            var cus = cp.Customers;
            var cus1 = from e in cus
                       where e.Cid == Cid
                       select e;
            foreach (var res in cus1)
            {
                Console.WriteLine("{0} {1} {2} {3}", res.Cid, res.Cname, res.Caddr, res.mobileno);

            }

            cp.SaveChanges();
        }

        */
        public static void Insert()
        {
            CPContext c = new CPContext();
            var customers = new List<Customer>
            {
                new Customer{Cname="prasad",Caddr="chennai"},
                 new Customer{Cname="adi",Caddr="hyd"},
                  new Customer{Cname="sridevi",Caddr="rjy"},
                   new Customer{Cname="devika",Caddr="vij"}

            };
            customers.ForEach(s => c.Customers.Add(s));
            c.SaveChanges();
            var products = new List<Product>
            {
                new Product{Pname="rice",Pprice=45},
                 new Product{Pname="dal",Pprice=445},
                  new Product{Pname="maggie",Pprice=475},
                   new Product{Pname="onions",Pprice=85},
                    new Product{Pname="kandi pappu",Pprice=25},
                     new Product{Pname="pesara pappu",Pprice=55}
            };


            products.ForEach (P => c.Products.Add(P)) ;
            c.SaveChanges();
            var purchases = new List<Purchase>
            {
                new Purchase{OrderDate=Convert.ToDateTime("4-02-2020"),Pid=1,Cid=2},
                 new Purchase{OrderDate=Convert.ToDateTime("1-02-2020"),Pid=2,Cid=1},
                  new Purchase{OrderDate=Convert.ToDateTime("3-02-2020"),Pid=3,Cid=2},
                   new Purchase{OrderDate=Convert.ToDateTime("1-02-2020"),Pid=4,Cid=3}
            };


            purchases.ForEach(pr => c.Purchases.Add(pr));
            c.SaveChanges();
        }
        public static void showall()
        {
            CPContext c = new CPContext();
            var customers = c.Customers;
            Console.WriteLine("customer details are:");
            foreach (var C in customers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", C.Cid,C.Cname,C.Caddr);
            }
            Console.WriteLine("\n products are.....\n");
            var products = c.Products;
            foreach(var prd in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}", prd.Pid, prd.Pname, prd.Pprice);
            }

            Console.WriteLine("\n purchases are....\n");
            var purchases = c.Purchases;
            Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,8}{5,15}{6,15}", "purchid", "oderddate","Productid","product name","productprice", "custid", "custname");
            foreach(var pr in purchases)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,8}{5,15}{6,15}", pr.Id, pr.OrderDate.ToShortDateString(), pr.Pid, pr.Product.Pname
                    , pr.Product.Pprice, pr.Cid, pr.Customer.Cname);
            }

        }
    }
}
