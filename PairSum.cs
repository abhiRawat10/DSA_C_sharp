using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class PairSum
    {
        public void Entry()
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the sum: ");
            int sum = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine($"Pair found at index {i} and {j}");
                        return;
                    }
                }
            }

            Console.WriteLine("No Pair Found");


        }
    }
}
