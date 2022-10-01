using System;
namespace AbstractionLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //var animal1 = new Animal(); //it will give error cause Animal is abstruct class

            var myCat = new Cow();
            //myCat.AnimalSound();


            Animal[] ourAnimals =
            {
                new Cat(),
                new Cow(),
                new Sheep()
            };

            foreach (var item in ourAnimals)
            {
                var youAnimal = item as Sheep;
                if (youAnimal is Cat)
                {
                    Console.WriteLine("This is a cat");
                }
                else if (youAnimal is Cow)
                {
                    Console.WriteLine("This is a cow.");
                }
                else if(youAnimal is null)
                {
                    Console.WriteLine("It is not");
                }

                
            }
            //is relation
            Console.ReadLine();
        }
    }
}
