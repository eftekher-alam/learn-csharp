namespace LooselyCoupled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             -> Here we can pass Application1 or Application2 according to the need. 
             -> So we just make change here not inside the client class. 
                [ This scenario is looesly coupled ]
            */
            Client c1 = new Client(new Application2());
            c1.UseApp();
        }
    }
}