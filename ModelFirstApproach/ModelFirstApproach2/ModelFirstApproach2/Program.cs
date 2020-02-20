using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstApproach2
{
    class Program
    {
        static Model1Container mc = new Model1Container();
        static void Main(string[] args)
        {
            //insertbike();
          // insertcompany();
           // showbike();
            showcompany();

        }

        private static void showcompany()
        {
            Console.WriteLine("details of company");
            var company = mc.Companies;
            foreach (var s in company)
            {
                Console.WriteLine("{0} {1} {2} {3}", s.Cid, s.Cname, s.Clocation, s.Bid);

            }
        }

        private static void showbike()
        {
            Console.WriteLine("details of bike");
            var bike = mc.Bikes;
            foreach (var s in bike)
            {
                Console.WriteLine("{0} {1} {2} {3}", s.Bid, s.Bname, s.Bmodel, s.Bprice);

            }
        }

        private static void insertcompany()
        {
            Console.WriteLine("enter company name");
            string name = Console.ReadLine();
            Console.WriteLine("enter company location");
            string loc = Console.ReadLine();
            Console.WriteLine("enter Bike id");
            int id = int.Parse(Console.ReadLine());
            var company = new Company
            {
                Cname = name,
                Clocation = loc,
                Bid = id
            };
            mc.Companies.Add(company);
            mc.SaveChanges();
            Console.WriteLine("insert successfully");
        }

        private static void insertbike()
        {
            Console.WriteLine("enter Bike name");
            string name = Console.ReadLine();
            Console.WriteLine("enter Bike model");
            string model = Console.ReadLine();
            Console.WriteLine("enter Bike price");
            double price = double.Parse(Console.ReadLine());
            var bike = new Bike
            {
                Bname = name,
                Bmodel = model,
                Bprice = price
            };
            mc.Bikes.Add(bike);
            mc.SaveChanges();
            Console.WriteLine("insert successfully");
        }
    }
}
