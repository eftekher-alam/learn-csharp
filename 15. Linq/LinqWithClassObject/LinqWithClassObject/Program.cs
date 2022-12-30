using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWithClassObject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            students.Add(new Student() { Name = "Eftekher Alam", Id = 2006, Department = "CSE", UniId = "U1" });
            students.Add(new Student() { Name = "Rahim Ullah", Id = 2007, Department = "EEE", UniId = "U1" });
            students.Add(new Student() { Name = "Asfaque Rahman", Id = 2010, Department = "EEE", UniId = "U2" });
            students.Add(new Student() { Name = "Sakib Al Hasan", Id = 2011, Department = "CSE", UniId = "U2" });
            students.Add(new Student() { Name = "Mushfique Rahim", Id = 2011, Department = "RAC", UniId = "U3" });

            List<University> universities = new List<University>()
            {
                new University(){UID = "U1", UName = "Adorsho University" },
                new University(){UID = "U2", UName = "ABC University" },
            };
            var manager = new Manager(students, universities);
            // manager.AllStudents();
            Console.WriteLine("Department of CSE Called");
            manager.StudentOfCSE();
            manager.StudentOfU1();
            manager.StudentAndUniversity();
            Console.ReadLine();
        }
    }

    class Manager
    {
        List<Student> students;
        List<University> universities;
        public Manager(List<Student> students, List<University> universities)
        {
            this.students = students;
            this.universities = universities;
        }
        public void AllStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
        public void StudentOfCSE()
        {
            //It is lazily looding means cseStudent linque only execute when it will used. Here in this case, when in the foreache loop use cseStudent that time for every recourd the linq will execute. Check by using debugger.
            int i = 0; //Here i is used to understand the difference between eager loadding lazily loadding.
            //var cseStudents = from student in students
            //                  where student.Department.Contains("CSE")
            //                  select (student.Name, student.Department, ++i);

            //it is eager lodding means in cseStudents fully lood all data then go to next.
            var cseStudents = (from student in students
                               where student.Department.Contains("CSE")
                               select (student.Name, student.Department, ++i)).ToList();
            Console.WriteLine("---------> Students of CSE Department <---------");

            foreach (var item in cseStudents)
            {
                Console.WriteLine($"Name : {item.Name}\nDepartment : {item.Department}\ni : {i}\n");
            }
        }
        public void StudentOfU1()
        {
            IEnumerable<Student> U1student = from student in students join uni in universities on student.UniId equals uni.UID where uni.UName is "Adorsho University" select student;
            Console.WriteLine("---------> Students of Adorsho University <---------");
            foreach (var item in U1student)
            {
                Console.WriteLine(item);
            }
        }

        //Also take university name with student information
        public void StudentAndUniversity()
        {
            var result = from student in students join university in universities on student.UniId equals university.UID select new { StuName = student.Name, Dep = student.Department, UniName = university.UName };
            Console.WriteLine("---------> Student info university wise <---------");
            foreach (var item in result)
            {
                Console.WriteLine($"Student Name : {item.StuName} \nDepartment : {item.Dep} \nUniversity Name : {item.UniName}\n");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Department { get; set; }
        //foreign key
        public string UniId { get; set; }
        public override string ToString()
        {
            return $"Student Name : {Name} \nId : {Id} \nDepartment : {Department} \nUniversity Id : {UniId}\n" ;
        }
    }

    class University
    {
        public string UID { get; set; }
        public string UName { get; set; }

        public override string ToString()
        {
            return $"University Id : {UID} \nUinversity Name : {UName}";
        }
    }
}
