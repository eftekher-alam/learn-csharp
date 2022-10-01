using System;

namespace Chalange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Base Class
            var E1 = new Employee("Eftekher", 100000);
            Console.WriteLine(E1);

            //Trainee(Derived form Employe)
            var T1 = new Trainee("Short", 20000, 8, 5);
            T1.Work();
            Console.WriteLine(T1);

            //Boss(Derived form Employee)
            var B1 = new Boss("Michel", 3000000, true);
            B1.Lead();
            Console.WriteLine(B1);

            Console.ReadKey();
        }
    }
}
