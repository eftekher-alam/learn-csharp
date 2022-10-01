using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)     /*Main is a function, which is starting poin of program*/ 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("Hello World..!");
            Console.WriteLine("Hello Eftekher.");
            
            Console.ReadKey();
        }
    }
}
