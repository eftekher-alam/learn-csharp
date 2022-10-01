using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using new keyword and constructor
            Employee e1 = new Employee(101, "Eftekher");
            Console.WriteLine(e1);


            //Without new keyword and constructor.
            Human h1;
            h1.name = "Shuvo";
            h1.age = 24;
            Console.ReadKey();
        }
    }

    struct Employee
    {
        public int id;
        public string name;

        //All property must be assigned in ctor if ctor used.
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return "------> Employee Details <--------" + "\nId : " + id + "\nName : " + name;
        }
    }

    struct Human
    {
        public string name;
        public int age;
        private int status; 
    }
}
