using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 19 Registration Expression.");
            Console.WriteLine("Program #1: First Name");
            Console.WriteLine("Program #2: Last Name");
            Console.WriteLine("Program #3: Email");
            Console.WriteLine("Program #4: Mobile Format");
            Console.WriteLine("Program #5: Password Rule-1");
            Console.WriteLine("Program #6: Password Rule-2");
            Console.WriteLine("Program #7: Password Rule-3");
            Console.WriteLine("Program #8: Password Rule-4");
            Console.WriteLine("Program #8: Clear");

            Console.Write("\nPlease select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RegexUC1.UC1();
                    break;
                case 2:
                    RegexUC2.UC2();
                    break;
                case 3:
                    RegexUC3.UC3();
                    break;
                case 4:
                    RegexUC4.UC4();
                    break;
                case 5:
                    RegexUC5.UC5();
                    break;
                case 6:
                    RegexUC6.UC6();
                    break;
                case 7:
                    RegexUC7.UC7();
                    break;
                case 8:
                    RegexUC8.UC8();
                    break;
                case 9:
                    RegexUC9.UC9();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
            Console.ReadKey();
        }
    }
}
