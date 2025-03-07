using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            int n=arr.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n-i-1; j++)//-1 because of j+1
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
        }
    }
}
