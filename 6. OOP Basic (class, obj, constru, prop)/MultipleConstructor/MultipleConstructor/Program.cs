using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.Introduce();
           

            Human human2 = new Human("Eftekher", "Alam");
            human2.Introduce();

            Human human3 = new Human("Lipi", "Akter", "Black");
            human3.Introduce();

            Human human4 = new Human("Eftekher", "Alam", "Black", 24);
            human4.Introduce();

            Console.ReadKey();
        }
    }
}
