using System;

namespace AbstractBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow c = new Cow();
            c.Sleep();
        }
    }

    abstract class Animal
    {
        public abstract void Eat();
        public abstract void Sound();
        public void Sleep()
        {
            Console.WriteLine("Zzz..");
        }
    }

    class Cow : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cow gash khay..");
        }

        public override void Sound()
        {
            Console.WriteLine("Cow hamba hamba kora..");
        }
    }
}
