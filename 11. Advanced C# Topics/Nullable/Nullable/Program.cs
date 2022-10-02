using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> Id = null; //Make it nullable by Nullable Keyword
            int? NID = null; //Make it nullable by using question mark "?"
            Console.WriteLine($"Id : {Id}, NID : {NID}");
        }
    }
}
