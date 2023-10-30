using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MaximumSubarraySum
    {
        private static int GetMaxSum(int[] array, int size)
        {
            int sum = 0;
            int maxi = int.MinValue;

            for(int i = 0; i < size; i++)
            {
                sum += array[i];
                maxi = Math.Max(maxi, sum);
                if(sum < 0)
                {
                    sum = 0;
                }
            }
            return maxi;
        }
        public static void FindSum()
        {
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("Enter the element at {0} index : ", i));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe array is : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("{0} ", array[i]));
            }

            int ans = GetMaxSum(array, size);
            Console.WriteLine(String.Format("\nMaximum Subarray sum is : {0}", ans));

            Console.ReadKey(); 
        }
    }
}
