using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class ReverseString
    {
        public void Entry()
        {
            Console.WriteLine("Enter the String to Reverse");
            string? input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }

            StringBuilder sb = new StringBuilder(input);

            int i = 0;
            int j = input.Length - 1;

            while (i < j)
            {
                char t = sb[i];
                sb[i] = sb[j];
                sb[j] = t;
                i++;
                j--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
