using System;
namespace AbstractionLearn
{
    //It's a abstruct class therefore cannot able to make object of the class.
    //Only can be inherited to other class
    abstract class Animal
    {
        //Abstruct method only can be member of abstruct class
        public abstract void AnimalSound(); //it will be inplemented into derived class
        public void Sleep()
        {
            Console.WriteLine("Zzzz..");
        }
    }
}
