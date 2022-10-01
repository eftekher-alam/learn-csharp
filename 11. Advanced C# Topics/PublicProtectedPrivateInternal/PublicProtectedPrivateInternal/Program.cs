namespace PublicProtectedPrivateInternal
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.model = "BMW-203";  //Hence, model is public, it is accessable from other class.
            //car1.enginNo = "en28"; //It is not accessable outside of the car class.
            //owner = "Eftekher"; //It is not accessable here because it is procted var.
        }
    }

    class Car
    {
        public string model; //Public Modifier
        private string enginNo = "en20394812"; //Private Modifier, It is only eccessable in this class only
        protected string owner; //It is protected 
    }

    class BMW:Car
    {
        public void setInfo()
        {
            model = "BMW-2022"; //BMW inherit Car hence, public var are accessable.
            //enginNo = "sdlf"; //Not accessable because it is private, though it is inherit from Car class
            owner = "Eftekher"; //It is accessable here because this class inherit Car class.
            


        }
    }
}
