using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTakTko
{
    class Program
    {
        public static int user = 1;
        public static string[,] con = new string[,]
           {
                    {" 1 ", " 2 "," 3 "},
                    {" 4 ", " 5 "," 6 "},
                    {" 7 ", " 8 "," 9 "}
           };
        static void Main(string[] args)
        {
            display();
            processing();
        }

        public static void display()
        {

            Console.WriteLine($"{con[0, 0]}|{con[0, 1]}|{con[0, 2]}");
            Console.WriteLine("---|---|---");
            Console.WriteLine($"{con[1, 0]}|{con[1, 1]}|{con[1, 2]}");
            Console.WriteLine("---|---|---");
            Console.WriteLine($"{con[2, 0]}|{con[2, 1]}|{con[2, 2]}");
        }


        public static void processing()
        {
            string inputU1 = "";
            string inputU2 = "";

            if (user % 2 != 0)
            {
                Console.WriteLine("Note: To exit -1");
                Console.Write("User1 : ");
                string x = Console.ReadLine();
                if (int.Parse(x) > 0 && int.Parse(x) < 10 || x == "-1")
                    inputU1 = x;
                else
                {
                    Console.Clear();
                    display();
                    Console.WriteLine("Please enter correct input.");
                    processing();
                }
            }
            else
            {
                Console.WriteLine("Note: To exit -1");
                Console.Write("User2 : ");
                // inputU2 = Console.ReadLine();
                string x = Console.ReadLine();
                if (int.Parse(x) > 0 && int.Parse(x) < 10 || x == "-1")
                    inputU2 = x;
                else
                {
                    Console.Clear();
                    display();
                    Console.WriteLine("Please enter correct input.");
                    processing();
                }
            }
            user++;


            if (inputU1 == "-1" || inputU2 == "-1")
            {
                return;
            }


            if (inputU1 != "")
            {
                switch (inputU1)
                {
                    case "1":
                        con[0, 0] = " O ";
                        Console.Clear();
                        display();
                        break;
                    case "2":
                        con[0, 1] = " O ";
                        Console.Clear();
                        display();
                        break;
                    case "3":
                        con[0, 2] = " O ";
                        Console.Clear();
                        display();
                        break;
                    case "4":
                        con[1, 0] = " O ";
                        Console.Clear();
                        display();
                        break;
                    case "5":
                        con[1, 1] = " O ";
                        Console.Clear();
                        display();
                        break;
                    case "6":
                        con[1, 2] = " O ";
                        Console.Clear();
                        display();
                        break;
                    case "7":
                        con[2, 0] = " O ";
                        Console.Clear();
                        display();
                        break;
                    case "8":
                        con[2, 1] = " O ";
                        Console.Clear();
                        display();
                        break;
                    case "9":
                        con[2, 2] = " O ";
                        Console.Clear();
                        display();
                        break;
                }
            }

            else if (inputU2 != "")
            {
                switch (inputU2)
                {
                    case "1":
                        con[0, 0] = " X ";
                        Console.Clear();
                        display();
                        break;
                    case "2":
                        con[0, 1] = " X ";
                        Console.Clear();
                        display();
                        break;
                    case "3":
                        con[0, 2] = " X ";
                        Console.Clear();
                        display();
                        break;
                    case "4":
                        con[1, 0] = " X ";
                        Console.Clear();
                        display();
                        break;
                    case "5":
                        con[1, 1] = " X ";
                        Console.Clear();
                        display();
                        break;
                    case "6":
                        con[1, 2] = " X ";
                        Console.Clear();
                        display();
                        break;
                    case "7":
                        con[2, 0] = " X ";
                        Console.Clear();
                        display();
                        break;
                    case "8":
                        con[2, 1] = " X ";
                        Console.Clear();
                        display();
                        break;
                    case "9":
                        con[2, 2] = " X ";
                        Console.Clear();
                        display();
                        break;
                }
            }
            processing();
        }
    }
}
