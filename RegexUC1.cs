using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC1
    {
        public static void UC1()
        {
            Console.WriteLine("\nEnter First Name :");
            string inStr = Console.ReadLine();
            string firstName = "^[A-Z]{1}[a-zA-Z]{2,9}$";

            Regex regex = new Regex(firstName);
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
