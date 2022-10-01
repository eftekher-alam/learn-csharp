using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            /* >>>>>>>>>> Try Catch <<<<<<<<<
             If error occurred in a running software, that will shut down immediately. To avoid shut down software use try catch. 
                Here,
                string cannot be converted into int. So, there will occur an error and full program will shut down. To avoid shut down the program use try catch.
            */

           // Write program into try block, in which is possibility to occur error for the error the program might be shut down.
        startAgain:
            try
            {
                Console.Write("Please enter a number : ");
                int num1 = int.Parse(Console.ReadLine());
            }

            //We can use multiple catch block to catch desire exception if that occur.

            catch (FormatException)
            {

                Console.WriteLine("It is not into correct formation.");
            }

            //If any error occurs in the try block, the error will catch by the Catch Block where we can print error or throw;
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto startAgain;
            }
            //This block will execute whether an error occurs in Try Block or not.
            
            finally
            {
                Console.WriteLine("Program is running...");
            }


            // Handel divide by zore exception by try catch

            int num2 = 15;

            try
            {
                Console.WriteLine(num2 / 0);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program is running....");
            }
            
            Console.ReadLine();
        }
    }
}
