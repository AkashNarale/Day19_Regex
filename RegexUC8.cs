using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class RegexUC8
    {
        public static void UC8()
        {
            Console.WriteLine("\nType Password :");
            string inStr = Console.ReadLine();
            string Password4 = "^[a-zA-Z0-9]{1,}[A-Z]*[0-9]*[@&#%$*_-]+[a-zA-Z0-9]*$";

            Regex regex = new Regex(Password4);
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
