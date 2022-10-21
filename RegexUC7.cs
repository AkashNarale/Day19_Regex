using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC7
    {
        public static void UC7()
        {
            Console.WriteLine("\nType Password :");
            string inStr = Console.ReadLine();
            string Password3 = "^[a-z0-9]{1,}[A-Z]{1,}[a-zA-Z0-9]*";

            Regex regex = new Regex(Password3);
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
