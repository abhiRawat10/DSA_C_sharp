using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class MoveZeroesToEnd
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
            MoveZeroes(arr);
            Console.WriteLine("Array after moving zeroes to the end: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1 || nums.Length == 0) return;
            int left = 0; //goes to 0
            int right = 0; //goes to non zero
            while (left < nums.Length && nums[left] != 0)
            {
                left++;
            }
            right = left + 1;

            while (left < nums.Length && right < nums.Length)
            {

                while (left < nums.Length && nums[left] != 0)
                {
                    left++;
                }
                while (right < nums.Length && nums[right] == 0)
                {
                    right++;
                }
                if (!(left < nums.Length && right < nums.Length)) break;
                int temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
            }
        }
    }
}
