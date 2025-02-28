using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class MaxSubarraySumKadane
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
            Console.WriteLine("Enter the elements of the array: ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxSum = arr[0];
            int currSum = 0;

            for (int i = 0; i < n; i++)
            {
                currSum += arr[i];
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }
                if (currSum < 0)//if currSum is negative then we can start a new subarray and that mean curr is first element
                                // of next subarray but since its giving sum in negative so we dont count it
                {
                    currSum = 0;
                }

            }
            Console.WriteLine("Max Subarray Sum: " + maxSum);

        }
    }
}
