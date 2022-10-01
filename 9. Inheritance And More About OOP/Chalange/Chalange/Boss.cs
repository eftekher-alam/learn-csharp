using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chalange
{
    class Boss:Employee
    {
        protected bool CompanyCar { get; set; }
        public Boss(string name, int salary, bool isCompanyCar) : base(name, salary)
        {
            CompanyCar = isCompanyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Boss lead the company");
        }
        public override string ToString()
        {
            return "------ Boss -------\n" + "Boss Name : " + Firstname + "\nSalary : " + Salary + "\nHas Company Car : " + CompanyCar;
        }

    }
}
