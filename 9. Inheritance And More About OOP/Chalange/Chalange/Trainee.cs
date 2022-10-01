using System;

namespace Chalange
{
    class Trainee:Employee
    {
        protected int WorkHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee(string firstname, int salary, int workHours, int schoolHours):base(firstname, salary)
        {
            WorkHours = workHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {

        }
        public override void Work()
        {
            Console.WriteLine("Work time : " + WorkHours + "H");
        }
        public override string ToString()
        {
            return "------ Trainee -------\n"+"Trainee Name : " + Firstname + "\nSalary : " + Salary + "\nWorkHours : " + WorkHours + "\nSchoolHours" + SchoolHours;
        }
    }
}
