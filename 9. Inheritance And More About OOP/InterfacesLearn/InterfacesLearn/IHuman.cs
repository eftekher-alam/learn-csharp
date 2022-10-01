
namespace InterfacesLearn
{
    interface IHuman
    {
        string Name { get; set; }
        int Age { get; set; }
        void Work();
        void Eat();
    }
}
