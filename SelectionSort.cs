using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            int n=arr.Length;
            for(int i = 0; i < n; i++)
            {
                int max = 0;
                for(int j = 0; j < n - i;j++)
                {
                    if(arr[j] > arr[max])max=j;
                }
                int temp = arr[n - i - 1];
                arr[n - i - 1] = arr[max];
                arr[max] = temp;

            }
        }
    }
}
