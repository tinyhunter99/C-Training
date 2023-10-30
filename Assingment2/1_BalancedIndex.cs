using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class BalancedIndex
    {
        private static int Solve(int[] array, int size)
        {
            int totalSum = 0;
            for(int i = 0; i < size; i++)
            {
                totalSum += array[i];
            }

            int leftSum = 0;
            for(int i = 0; i < size; i++)
            {
                int rightSum = totalSum - array[i] - leftSum;
                if(rightSum == leftSum)
                {
                    return i;
                }
                leftSum += array[i];
            }
            return -1;
        }
        public static void FindBalancedIndex()
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

            int ans = Solve(array, size);
            Console.WriteLine(String.Format("\nThe Balanced Index is : {0}", ans));

            Console.ReadKey();
        }
    }
}
