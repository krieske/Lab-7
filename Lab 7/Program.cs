using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a program that validates zip codes
            Console.WriteLine("Please enter a valid zip code");
            string input = Console.ReadLine();

            // 1. name - regex

            //if (Regex.IsMatch(input, @"^\d{5}$")) // @ turns off escape sequence that doesn't allow for \d to be used.
            // {
            //     Console.WriteLine("You entered a valid zip code!");

            // }
            //else
            // {
            //     Console.WriteLine("Invalid zip code, please try again.");
            // }
            //==============================================================================



            //LAB 7 REGULAR EXPRESSION

            // 1. name: ("^[A-Z][a-z]{1,29}$")
            // 2. email: ("^[A-Za-z0-9]{5,30}@[A-Za-z]{5,10}.[A-Za-z0-9]{2,3}$")
            // 3. phone number: (@"^\d{3}-\d{3}-\d{4}$")
            // 4. date: (@"^\d{2}\/\d{2}\/\d{4}$")
            // 5. HTML: (@"^<\/?\w+((\s+\w+(\s*=\s*(?:""[^""]*""|'[^']*'|[^'"">\s]+))?)+\s*|\s*)\/?>$")
            // (when translated, output would be (?:&quot;[^&quot;]*&quot;|&#39;[^&#39;]*&#39;|[^&#39;&quot;>)
            // (or would represent " < " " ' " and " " ")
            while (!Regex.IsMatch(input, @"^\d{5}$"))
            {
                Console.WriteLine("Invalid zip code, please try again.");
                input = Console.ReadLine();
            }
            Console.WriteLine("You entered a valid zip code!");
        }
    }
}
