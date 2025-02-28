using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class MissingNumber
    {
        public void entry()
        {
            Console.WriteLine("Enter the number of elements in the array: ");

            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array with 1 number missing from 1 to n: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            int reqSum = (n * (n + 1) )/ 2;
            Console.WriteLine($"Missing number is: {reqSum - sum}");
        }
    }
            
}
