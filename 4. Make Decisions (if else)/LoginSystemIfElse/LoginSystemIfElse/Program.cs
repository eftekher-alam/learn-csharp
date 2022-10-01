using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystemIfElse
{
    class Program
    {
        static string userName = "", password = "", regUserName = "", regPassword = "";
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>> Welcome to dashbord <<<<<<<<");
            start:
            Console.WriteLine("\n\n");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Login");
            Console.Write("Choose an option :");
            
            int ip = int.Parse(Console.ReadLine());
           
            
            if (ip == 1)
            {
                CreateAccount();
                goto start;
            }
            else if (ip == 2)
            {
                Login();
            }
            else
            {
                Console.WriteLine("Please select correct option.");
            }
            goto start;

            Console.Read();
        }

        public static void CreateAccount()
        {

            Console.WriteLine("\n\n>>>>>>>>>>> Create Account <<<<<<<<<<<");
            Console.Write("username : ");
            regUserName = Console.ReadLine();

            Console.Write("password : ");
            regPassword = Console.ReadLine();

            if (regUserName != "" && regPassword != "")
            {
                Console.WriteLine("Successfully registired.");
            }
        }

        public static void Login()
        {
            Console.WriteLine("\n\n>>>>>>>>>>> Login <<<<<<<<<<<");

            Console.Write("username : ");
            if (Console.ReadLine() == regUserName)
            {
                Console.Write("password : ");
                if (Console.ReadLine().Equals(regPassword))
                {

                    Console.WriteLine("Hello, Mr. " + userName);
                }
                else
                {
                    Console.WriteLine("Incorrect password");
                }
            }
            else
            {
                Console.WriteLine("Incorrect username..!");
            }
        }
            
    }
}

