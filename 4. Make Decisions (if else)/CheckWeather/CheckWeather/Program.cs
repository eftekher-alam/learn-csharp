using System;

namespace CheckWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the weather ?");
            //int temperatur = int.Parse(Console.ReadLine());
            int temperatur = 20;

            //This one will be true for 20
            if (temperatur <= 20)
                Console.WriteLine("Wear sweater.");

            // This one also will be true for 20
            // Here both will be execute 
            if (temperatur == 20)
                Console.WriteLine("Wear t-shirt.");
            if (temperatur > 30)
                Console.WriteLine("Just wear pants");

            Console.Read();
           
        }
    }
}
