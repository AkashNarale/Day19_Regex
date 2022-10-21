using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC9
    {       
        public static void UC9()
        {
            Console.WriteLine("\nEnter your email :");
            string inStr = Console.ReadLine();
            string email = "^[A-Za-z0-9]+([._#][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";

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
