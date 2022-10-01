using System;
namespace InterfacesLearn
{
    class Man:IHuman
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }


        public void Work()
        {
            Console.WriteLine("I Work 4 hours of a day");
        }

        public void Eat()
        {
            Console.WriteLine("I take 3 meal each day.");
        }
    }
}
