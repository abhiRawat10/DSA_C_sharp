using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class LeapYear
    {
        public void Entry()
        {
            Console.WriteLine("Enter the year: ");

            int year = Convert.ToInt32(Console.ReadLine());


            // either divisible by 4 and not by 100
            // or divisible by 400
            if (year %4==0 && year %100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
