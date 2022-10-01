using System;
namespace PolymorphismBasic
{
    class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("HP = " + HP + "\nColor = " + Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired..!");
        }
    }
}
