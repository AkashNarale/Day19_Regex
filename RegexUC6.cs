using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC6
    {
        public static void UC6()
        {
            Console.WriteLine("\nType Password :");
            string inStr = Console.ReadLine();
            string Password2 = "^[a-z]{1,}[A-Z]{1,}[a-zA-Z]*";

            Regex regex = new Regex(Password2);
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
