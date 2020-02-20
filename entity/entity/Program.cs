using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    class Program
    {
        static void Main(string[] args)
        {
          //  insertdata();
          // deletedata();
         // update();
            //showalldata();
           serachbyid();

        }

         private static void insertdata()
        {
            Console.WriteLine("enter employee id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("enter desifgnatiuon");
            string Desg = Console.ReadLine();
            Console.WriteLine("enter employee salary");
           
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inserted successfully");
            EmployeeContext ect = new EmployeeContext();
            ect.Employees.Add(new Employee
            {   Eid = id,
                Ename = name,
                Designation = Desg,
                salary = sal

            });
            ect.SaveChanges();
        }



        public static void deletedata()
        {
            EmployeeContext emptx = new EmployeeContext();
            Console.WriteLine("enter id to delete details");
            int id = int.Parse(Console.ReadLine());
            var emp1 = emptx.Employees;
            var emp = from e in emp1
                      where e.Eid == id
                      select e;

            emptx.Employees.RemoveRange(emp);
            foreach (var res in emp)
            {
                Console.WriteLine("the deleted row is {0} {1} {2} {3}", res.Eid, res.Ename, res.Designation, res.salary);
            }
            emptx.SaveChanges();

        }


        public static void update()
        {
            EmployeeContext emptx = new EmployeeContext();
            Console.WriteLine("enter id to update details");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter salary details");
            double sal = double.Parse(Console.ReadLine());
            var employees = emptx.Employees;

            var emp = from e in employees
                      where e.Eid == id
                      select e;

            Console.WriteLine("row is updated check once");
            foreach (var e in emp)
            {
                e.salary = sal;
            }
            emptx.SaveChanges();

        }


        public static void showalldata()
        {
            EmployeeContext emptx = new EmployeeContext();
            var employees = emptx.Employees;
            foreach (var emp in employees)
            {
                Console.WriteLine("the entire data is {0}\t{1}\t{2}\t{3}\t", emp.Eid, emp.Ename, emp.Designation, emp.salary);
            }

        }


        private static void serachbyid()
        {
            EmployeeContext emptx = new EmployeeContext();
            Console.WriteLine("search employee id");
            int id = int.Parse(Console.ReadLine());

           
            var emp1 = emptx.Employees;
            var emp = from e in emp1
                      where e.Eid == id
                      select e;
            foreach (var res in emp)
            {
                Console.WriteLine("searched row is {0} {1} {2} {3}", res.Eid,res.Ename,res.Designation,res.salary);
            }

        }
    }
}
