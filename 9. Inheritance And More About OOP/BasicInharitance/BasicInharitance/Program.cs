using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInharitance
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bpost1 = new Post();
            Console.WriteLine(Bpost1);
            var Bpost2 = new Post("P#01 Good Morning Friends", "eftekher123");
            Console.WriteLine(Bpost2);

            Bpost1.PublicVar = "I'm public, you can call me from anywhere";
            Post.StaticVar = "I'm Static, you can call me without making object.";

            var Dvideo1 = new VideoPost();
            Console.WriteLine(Dvideo1);

            var Dvideo2 = new VideoPost(10, 50, "I'm Swimming...!", "eftekher2022");
            Console.WriteLine(Dvideo2);
            Dvideo2.Play();
            Console.Read();
            Dvideo2.Stop();


            Console.ReadKey();
        }
    }
}
