using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class StringCompresseion
    {
        public void Entry()
        {
            Console.WriteLine("Enter the String to compress");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }
            Console.WriteLine($"Compressed string is {Compress(input)}");
        }
        public string Compress(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            StringBuilder res = new StringBuilder();
            int count = 1;
            for (int i = 1; i < sb.Length; i++)
            {
                if (sb[i] != sb[i - 1])
                {
                    res.Append($"{count}{sb[i - 1]}");
                    count = 0;
                }
                count++;
            }
            res.Append($"{count}{sb[sb.Length - 1]}");
            return res.ToString();
        }
    }
}
