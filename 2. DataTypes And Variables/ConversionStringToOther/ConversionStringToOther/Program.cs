using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionStringToOther
{
    class Program
    {
        static void Main(string[] args)
        {

            //Numaric to string
            int bigAmount = 130000000;
            string amount = bigAmount.ToString(); // "130000000"
            Console.WriteLine("int Converted into string : " + amount);

            // >>>>>>>>> string to numaric (Only parse) <<<<<<<<<<<<
            Console.WriteLine("Enter a number to check Parse: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(p);

            string sNum1 = "1000";
            float x = float.Parse(sNum1);

            // >>>>>>>>> string to numaric (Tryparse) <<<<<<<<<<
            // it will handel if string data doesn't converted into desier type

            Console.WriteLine("Enter a number to check TryParse : ");
            string input = Console.ReadLine();
            float convertedIntData, num1;
            // If Tryparse faild it will return false which assigened to ConverStatus var. First argument of Tryparse is input which value to be convert and second argument will hold the converted value. 
            bool ConvertStatus = float.TryParse(input, out convertedIntData);


            // here I used the ConvertStatus. I also can use it for other purpose
            // if (float.TryParse(input, out convertedIntData)) 
            if (ConvertStatus)
            {
                num1 = convertedIntData;
            }
            else
            {
                num1 = 0;
                Console.WriteLine("Formate was incorrect. so the num = " + num1 +" assigned.");
            }

            Console.Read();
        }
    }
}
