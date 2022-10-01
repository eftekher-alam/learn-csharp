using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfArry
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************** Way - 1 ***************/
            int[] grades = new int[5]; //It will takes only 5 grades.

            // Assigning value into the array
            grades[0] = 3;
            grades[1] = 4;
            grades[5] = 5;

            /*************** Way - 2 ***************/
            //Declare and assigning in the same line.
            float[] mathGrades = { 3.50f, 4.00f, 3.33f, 2.99f, 3.40f};

            /*************** Way - 3 ***************/
            string[] studentName = new string[] { "Eftekher", "Alam", "Shuvo" };

        }
    }
}
