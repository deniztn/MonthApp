using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Month name:");
            string month = Console.ReadLine().ToUpper();
            if (month == "DECEMBER " || month == "JANUARY " || month == "FEBRUARY")
            {
                Console.Write("Winter");
            }
            else if (month == "MARCH" || month == "APRIL" || month == "MAY")
            {
                Console.Write("spring");
            }
            else if (month == "JUNE" || month == "JULLY" || month == "AUGUST")
            {
                Console.Write("Summer");
            }
            else if (month == "SEPTEMBER" || month == "OCTOBER" || month == "NOVEMBER")
            {
                Console.Write("AUTUMN");
            }
            else
                Console.Write("error");
            Console.ReadKey();
        }
    }
}
