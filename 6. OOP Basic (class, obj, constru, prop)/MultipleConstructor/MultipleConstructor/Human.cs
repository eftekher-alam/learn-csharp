using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleConstructor
{
    class Human
    {
        string firstName = "Nick", lastName = "Hanoi", eyeColor;
        int age;

        //public string firstName { get; set; }
        //public string lastName { get; set; }
        //public string eyeColor { get; set; }
        //public int age { get; set; }

        //This constructor is withou any parameter.
        public Human()
        {
            Console.WriteLine("Object is created...!");
        }

        //This constructor only has two parameter.
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //This constructor has three parameter
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        //This constructor has all the parameter 
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }



        public void Introduce()
        {

            if (eyeColor == null && age == 0)
            {
                Console.WriteLine($"Hi I'm {firstName} {lastName}");
            }
            else if (age == 0)
            {
                Console.WriteLine($"Hi I'm {firstName} {lastName} and, my eye color is {eyeColor}");
            }
            else
            {
                Console.WriteLine($"Hi I'm {firstName} {lastName} and I'm {age} years old, my eye color is {eyeColor}");
            }
        }
    }
}
