using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class MergeSort
    {
        public static void Conquer(int[] arr,int low,int mid,int high)
        {
            
            int[] temp = new int[high - low + 1];
            int k = 0;
            int i = low;
            int j = mid + 1;


            while (i<=mid && j<=high)
            {
                if(arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else temp[k++] = arr[j++];
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
            while(j <= high)
            {
                temp[k++] = arr[j++];
            }

            int t = low;
            for(int n = 0; n < temp.Length; n++)
            {
                arr[t++] = temp[n];
            }
        }
        public static void Divide(int[] arr, int low, int high)
        {
            if(low>=high) return;

            int mid = low + (high - low) / 2;
            Divide(arr,low,mid);
            Divide(arr,mid+1,high);
            Conquer(arr,low,mid,high);
        }
    }
}
