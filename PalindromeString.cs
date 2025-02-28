using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class PalindromeString
    {
        public void Entry()
        {
            Console.WriteLine("Enter the String to check if it is a Palindrome");
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
                if (sb[i] != sb[j])
                {
                    Console.WriteLine("Not a Palindrome");
                    return;
                }
                i++;
                j--;
            }
            Console.WriteLine("Palindrome");
        }
    }
}
