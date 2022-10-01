using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndAccessPrivateVar
{
    class Human
    {
        //by default it will be private var
        string firstName, lastName, eyeColor;
        int age;

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor; 
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm " + firstName + " " + lastName + "\nMy eye is " + eyeColor + "\nI'm " + age + " years old.");
        }
    }
    

}
