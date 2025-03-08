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
                int min = i;
                for(int j = i+1; j < n;j++)
                {
                    if(arr[j] < arr[min])min=j;
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;

            }
        }
    }
}
