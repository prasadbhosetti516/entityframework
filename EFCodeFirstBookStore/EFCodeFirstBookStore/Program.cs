using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstBookStore
{
    class Program
    { static Context c = new Context();
        static void Main(string[] args)
        {
            insertdata();

//            showdata();

        }

        private static void showdata()
        {
            Console.WriteLine("book details are");
            var books = c.books;
            foreach (var z in books)
            {
                Console.WriteLine("{0}\t{1}\t{2}", z.Bid, z.Btitle, z.Bprice);
            }

            Console.WriteLine("author details are:");
            var authors = c.authors;
            foreach (var y in authors)
            {
                Console.WriteLine("{0}\t{1}\t{2}", y.Aid, y.Aname, y.Aaddr, y.Bid);
            }

            Console.WriteLine("transaction details are:");
            var details = c.details;
            foreach( var x in details)
            {
                Console.WriteLine("{0}\t{1}", x.Tid, x.PublishDate);
            }
        }

        private static void insertdata()
        {
            Console.WriteLine("enter no of entries");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Context c = new Context();
                Console.WriteLine(".............book details are:...........");
                Console.WriteLine("enter book name");
                string title = Console.ReadLine();
                Console.WriteLine("enter book price");
                Console.WriteLine("enter detil id");
                int D
                double price = double.Parse(Console.ReadLine());
                var books = new List<Book>
            {
              new Book{ Btitle=title,Bprice=price}
            };
                books.ForEach(b => c.books.Add(b));
                c.SaveChanges();

                Console.WriteLine("............authior detaiuls are:.............");
                Console.WriteLine("enter author name");
                string name = Console.ReadLine();
                Console.WriteLine("enter author address");
                string addr = Console.ReadLine();
                Console.WriteLine("enter bid");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("inserted successfully");
                var authors = new List<Author>
            {
              new Author{ Aname=name, Aaddr =addr,Bid=bid}

            };
                authors.ForEach(a => c.authors.Add(a));
                c.SaveChanges();


                Console.WriteLine("......................details.....................");
                Console.WriteLine("enter date");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                var details = new List<Detail>
            {
                new Detail{PublishDate=date}
            };
                details.ForEach(d => c.details.Add(d));
                c.SaveChanges();
            }
        }
            
       
        
    }
} 
