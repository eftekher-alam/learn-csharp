using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chalange
{
    class Employee
    {
        protected string Firstname { get; set; }
        protected int Salary { get; set; }


        public Employee(string firstName, int salary)
        {
            Firstname = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Work time of Employee");
        }

        protected void Pause()
        {
            Console.WriteLine("Pause for Employee");
        }

        public override string ToString()
        {
            return "------ Employee -------\n" + "Employee Name : " + Firstname + "\nSalary : " + Salary;
        }
    }
}
