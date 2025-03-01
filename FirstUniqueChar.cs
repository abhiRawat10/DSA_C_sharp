using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class FirstUniqueChar
    {
        public void Entry()
        {
            Console.WriteLine("Enter the String to find the first unique character");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (char c in input)
            {
                if (dict[c] == 1)
                {
                    Console.WriteLine($"First unique character is {c}");
                    return;
                }
            }
            Console.WriteLine("No unique character found");
        }
    }
}
