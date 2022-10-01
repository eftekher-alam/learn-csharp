using System;
namespace AbstractionLearn
{
    class Cat:Animal
    {
        public override void AnimalSound()
        {
            base.Sleep();
            Console.WriteLine("Mau Mau Mau");
        }
    }
}
