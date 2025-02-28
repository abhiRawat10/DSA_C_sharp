using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class IntersectionOf2Array
    {
        public void Entry()
        {
            Console.WriteLine("Enter the number of elements in the first array: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter the elements of the first array: ");
            int[] arr1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of elements in the second array: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter the elements of the second array: ");
            int[] arr2 = new int[n2];

            for (int i = 0; i < n2; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Intersection of the two arrays: ");
            int[] res = Intersection(arr1, arr2);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }

        }





        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> fq = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (fq.ContainsKey(nums1[i]))
                {
                    fq[nums1[i]]++;
                }
                else
                {
                    fq[nums1[i]] = 1;
                }
            }

            List<int> li = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {

                if (fq.TryGetValue(nums2[i], out int value))
                {
                    //dictionary.TryGetValue(key, out value)
                    if (value > 0)
                    {
                        fq[nums2[i]]--;
                        li.Add(nums2[i]);
                    }
                }
            }

            int[] res = li.ToArray();
            return res;


        }
    }
}
