using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Leaders
    {
        private static int FindLeaders(int[] array, int size)
        {
            int count = 1;
            int rightMax = array[size - 1];
            for(int i = size - 2; i >= 0; i--)
            {
                if(rightMax < array[i])
                {
                    rightMax = array[i];
                    count++;
                }
            }
            return count;
        }
        public static void CountLeaders()
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

            int count = FindLeaders(array, size);
            Console.WriteLine(String.Format("\nThe Count of leaders in given array is : {0}", count));

            Console.ReadKey();
        }
    }
}
