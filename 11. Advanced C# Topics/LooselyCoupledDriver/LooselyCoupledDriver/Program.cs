namespace LooselyCoupledDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Bike myBike = new Bike();
            //We just pass car or bike object. Both object will accept automatically. No need to change object type inside the Driver class
            Driver myDriver = new Driver(myBike);   
            myDriver.StartVehicle();
        }
    }
}