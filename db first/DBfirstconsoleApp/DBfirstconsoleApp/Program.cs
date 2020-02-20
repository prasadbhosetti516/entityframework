using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBfirstconsoleApp
{
    class Program
    {
        static anilEntities ae = new anilEntities();
        static void Main(string[] args)
        {
            allcourses();
            allstudents();
            insertstudent();
            insertcourse();
        }

        private static void insertcourse()
        {
           Console.WriteLine("******************enter course detiasls**********************");
            Console.WriteLine("enter course id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter course type");
            string type = Console.ReadLine();

            Console.WriteLine("enter course startdate");
            DateTime coursetym = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("enter course fee");
            decimal fee = decimal.Parse(Console.ReadLine());
            Console.WriteLine(" .................inserted course details successfuly..................");
            var course = new course
            {
                courseid = id,
                coursetype = type,
                startdate = coursetym,
                fees = fee
            };
            ae.courses.Add(course);
            ae.SaveChanges();
        }

        private static void insertstudent()
        {
            Console.WriteLine("******************enter student detiasls**********************");
            Console.WriteLine("enter student id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("enter student course");
            string course = Console.ReadLine();
            Console.WriteLine("enter student address");
            string addr = Console.ReadLine();
            Console.WriteLine(" .................inserted student detials successfuly..................");
            var student = new student
            {
                id = id,
                sname = name,
                scourse = course,
                sadd = addr
            };
            ae.students.Add(student);
            ae.SaveChanges();
        }

        private static void allstudents()
        {
            Console.WriteLine("///////////////////all available students  are//////////////////////// ");
            var students = ae.students;
            foreach (var x in students)
            {
                Console.WriteLine("{0}\t {1}\t {2}\t {3}", x.id, x.sname, x.scourse, x.sadd);
            }
        }

        private static void allcourses()
        {
            Console.WriteLine("///////////////////all available courses are//////////////////////// ");
            var courses = ae.courses;
            foreach (var z in courses)
            {
                Console.WriteLine("{0}\t {1}\t {2}\t {3} ", z.courseid, z.coursetype, z.startdate, z.fees);
            }
        }
    }
}
