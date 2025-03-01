using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class LongestNonRepeatingSbstring
    {
        public void Entry()
        {
            Console.WriteLine("Enter the String to find the longest non-repeating substring");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int start = 0;
            int end = 0;
            int max = 0;

            while (end < input.Length)
            {
                if (dict.ContainsKey(input[end]))
                {
                    start= Math.Max(dict[input[end]] + 1, start);
                }


                dict[input[end]] = end;
                max = Math.Max(max, end - start + 1);
                end++;

            }
            Console.WriteLine($"Longest non-repeating substring is {input.Substring(start, max)}");
        }
    }
}
