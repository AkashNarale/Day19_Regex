using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC4
    {
        public static void UC4()
        {
            Console.WriteLine("\nMobile No :");
            string inStr = Console.ReadLine();
            string Mobile = "^[0-9]{2}[ ]*[0-9]{10}$";

            Regex regex = new Regex(Mobile);
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
