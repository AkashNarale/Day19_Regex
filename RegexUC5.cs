using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC5
    {
        public static void UC5()
        {
            Console.WriteLine("\nType Password :");
            string inStr = Console.ReadLine();
            string Password1 = "^[A-Za-z]{8}$";

            Regex regex = new Regex(Password1);
            if (regex.IsMatch(inStr))
            {
                Console.WriteLine("\nValid");
            }
            else
            {
                Console.WriteLine("\nInvalid");
            }
        }
    }
}
