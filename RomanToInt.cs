using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class RomanToInt
    {
        public void Entry()
        {
            Console.WriteLine("Enter the Roman number to convert to Integer");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("No input provided.");
                return;
            }
            Console.WriteLine($"Integer value of {input} is {RtoI(input)}");
        }
        public int RtoI(string s)
        {

            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1 || findValue(s[i]) >= findValue(s[i + 1]))
                    res += findValue(s[i]);

                else res -= findValue(s[i]);
            }
            return res;
        }
        public int findValue(char i)
        {
            switch (i)
            {
                case 'I':
                    return 1;

                case 'V':
                    return 5;

                case 'X':
                    return 10;

                case 'L':
                    return 50;

                case 'C':
                    return 100;

                case 'D':
                    return 500;

                case 'M':
                    return 1000;

                default:
                    return -1;
            }
        }
    }
}
