using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class PowerOf2Table
    {
        public void Entry()
        {
            Console.WriteLine("Enter the number till you want to print the table of power of 2: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n<=0 || n>=31)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int currPow = 1;
            for(int i=1; i <= n; i++)
            {
                currPow *= 2;
                Console.WriteLine($"2^{i} = {currPow}");
            }

        }
    }
}
