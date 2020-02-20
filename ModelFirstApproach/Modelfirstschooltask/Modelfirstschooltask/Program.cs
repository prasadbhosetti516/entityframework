using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelfirstschooltask
{
    class Program
    {
        static Model1Container mc = new Model1Container();
        static void Main(string[] args)
        {
            //showschool();
            // showstudent();
            // showexam();
            //showcourse();
            // showsubject();
            showresult();
            insertschooldata();
            insertstudentdata();
            insertexamdata();
            insertcoursedata();
            insertsubjectdata();
            insertresultdata();
        }

        private static void insertresultdata()
        {
            Console.WriteLine("enter  result details");
            Console.WriteLine("enter result");
            string desc = Console.ReadLine();


            Console.WriteLine("inserted result details successfully check in db");
            var result = new Result
            {
                Resdesc = desc

            };
            mc.Results.Add(result);
            mc.SaveChanges();
        }

        private static void insertsubjectdata()
        {
            Console.WriteLine("enter  subject details");
            Console.WriteLine("enter subject name");
            string name = Console.ReadLine();

            Console.WriteLine("enter course id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter result id");
            int id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserted subject details successfully check in db");
            var subject = new Subject
            {
                Subname = name,
                CourseCid = id,
                Rid = id1

            };
            mc.Subjects.Add(subject);
            mc.SaveChanges();
        }

        private static void insertcoursedata()
        {
            Console.WriteLine("enter  course details");
            Console.WriteLine("enter course name");
            string name = Console.ReadLine();
            Console.WriteLine("enter course credits");
            int credits = int.Parse(Console.ReadLine());
            Console.WriteLine("enter subject id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter exam id");
            int id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserted course details successfully check in db");
            var course = new Course
            {
                Cname = name,
                Ccredits = credits,
                Subid = id,
                ExamEid = id1

            };
            mc.Courses.Add(course);
            mc.SaveChanges();
        }

        private static void insertexamdata()
        {
            Console.WriteLine("enter exam details");
            Console.WriteLine("enter exam name");
            string name = Console.ReadLine();
            Console.WriteLine("enter exam location");
            string loc = Console.ReadLine();
            Console.WriteLine("enter course id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("inserted exam details successfully check in db");
            var exam = new Exam
            {
                Ename = name,
                Examlocation = loc,
                Cid = id

            };
            mc.Exams.Add(exam);
            mc.SaveChanges();
        }

        private static void insertstudentdata()
        {
            Console.WriteLine("enter  student details");
            Console.WriteLine("enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("enter student gender");
            string gen = Console.ReadLine();
            Console.WriteLine("enter exam id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter school id");
            int id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserted student details successfully check in db");
            var student = new Student
            {
                Stname = name,
                Stgender = gen,
                Eid = id,
                Stid = id1

            };
            mc.Students.Add(student);
            mc.SaveChanges();
        }

        private static void insertschooldata()
        {
            Console.WriteLine("enter  school details");
            Console.WriteLine("enter school name");
            string name = Console.ReadLine();
            Console.WriteLine("enter school loacation");
            string loc = Console.ReadLine();
            Console.WriteLine("enter student id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("inserted school details successfully check in db");
            var school = new School
            {
                Sname = name,
                Slocation = loc,
                Stid = id
            };
            mc.Schools.Add(school);
            mc.SaveChanges();
        }

        private static void showresult()
        {
            Console.WriteLine("*********result details are********");
            var result = mc.Results;
            foreach (var f in result)
            {
                Console.WriteLine("{0} {1}", f.Rid, f.Resdesc);
            }
        }

        private static void showsubject()
        {
            Console.WriteLine("*********subject details are********");
            var subject = mc.Subjects;
            foreach (var e in subject)
            {
                Console.WriteLine("{0} {1} {2} {3}", e.Subid, e.Subname, e.Rid, e.CourseCid);
            }
        }

        private static void showcourse()
        {
            Console.WriteLine("*********course details are********");
            var course = mc.Courses;
            foreach (var d in course)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", d.Cid, d.Cname, d.Ccredits, d.Subid, d.ExamEid);
            }
        }

        private static void showexam()
        {
            Console.WriteLine("*********exam details are********");
            var exam = mc.Exams;
            foreach (var c in exam)
            {
                Console.WriteLine("{0} {1} {2} {3}", c.Eid, c.Ename, c.Examlocation, c.Cid);
            }
        }

        private static void showstudent()
        {
            Console.WriteLine("*********students details are********");
            var student = mc.Students;
            foreach (var b in student)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", b.Stid, b.Stname, b.Stgender, b.Eid, b.SchoolSid);
            }
        }

        private static void showschool()
        {
            Console.WriteLine("*********school details are********");
            var school = mc.Schools;
            foreach (var a in school)
            {
                Console.WriteLine("{0} {1} {2} {3}", a.Sid, a.Sname, a.Slocation, a.Stid);
            }
        }
    }
}
