using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int n=arr.Length;
            for(int i = 1; i < n; i++)
            {
                int j = i-1;
                int temp = arr[i];
                while(j > 0 && arr[j] > temp)
                {
                    arr[j+1] = arr[j--];
                }
                arr[j + 1] = temp;
            }
        }
    }
}
