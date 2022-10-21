using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC3
    {
        public static void UC3()
        {
            Console.WriteLine("\nEnter Emil ID :");
            string inStr = Console.ReadLine();
            string email = "^[A-Za-z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";

            Regex regex = new Regex(email);
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
