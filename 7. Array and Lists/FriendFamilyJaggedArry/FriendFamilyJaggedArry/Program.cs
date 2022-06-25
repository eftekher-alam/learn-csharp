using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFamilyJaggedArry
{
    class Program
    {
        static void Main(string[] args)
        {
            //I have three friend make array for each friend and each friend stored their family member name in own array.
            string[] eftekher = new string[] { "Khelada Begum", "Shohag" };
            string[] manik = new string[] { "Hridoy Rana", "Jakir" };
            string[] borhan = new string[] { "Abudul Rahim", "Sayem" };

            string[][] friendFamily = new string[3][];

  

            friendFamily[1] = manik;
            friendFamily[2] = new string[] { "Lipi", "Shuvo" };
            friendFamily[0] = eftekher;


            foreach (var friend in friendFamily)
            {
                foreach(var familyMembers in friend)
                {
                    Console.WriteLine(familyMembers);
                }
            }
            Console.ReadKey();
        }
    }
}
