using System;
using System.IO;
namespace ReadWriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read File
            string x = File.ReadAllText(@"D:\MyDoc.txt");
            Console.WriteLine(x);
            

            //Write File
            string[] z = { "Hello bangladesh", "This is my motherland"};
            System.IO.File.WriteAllLines(@"D:\MyDoc.txt", z);


            using (StreamWriter f = new StreamWriter(@"D:\MyDoc.txt", true))
            {
                f.WriteLine("line1");
                f.WriteLine("line2");
                f.WriteLine("line3");
            };
            Console.ReadKey();
        }
    }
}
