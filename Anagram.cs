using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class Anagram
    {
        public void Entry()
        {
            Console.WriteLine("Enter the first string");
            string? input1 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string? input2 = Console.ReadLine();
            if (input1 == null || input2 == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }
            if (input1.Length != input2.Length)
            {
                Console.WriteLine("Not an Anagram");
                return;
            }

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in input1)
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
            foreach (char c in input2)
            {
                if (!dict.ContainsKey(c))
                {
                    Console.WriteLine("Not an Anagram");
                    return;
                }
                dict[c]--;
                if(dict[c] <0)
                {
                    Console.WriteLine("Not an Anagram");
                    return;
                }
                if (dict[c] == 0)
                {
                    dict.Remove(c);
                }
            }


            if (dict.Count == 0)//as all keys should be cancelled and removed
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not an Anagram");
            }
        }
    }
}
