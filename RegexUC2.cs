using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC2
    {
        public static void UC2()
        {
            Console.WriteLine("\nEnter Last Name :");
            string inStr = Console.ReadLine();
            string lastName = "^[A-Z]{1}[a-zA-Z]{2,9}$";

            Regex regex = new Regex(lastName);
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
