using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    internal class ProductArray
    {
        private static void PrintProduct(int[] array, int size)
        {
            int[] ans = new int[size];
            int[] leftProduct = new int[size];
            int[] rightProduct = new int[size];

            leftProduct[0] = 1;
            for(int i = 1; i < size; i++)
            {
                leftProduct[i] = leftProduct[i - 1] * array[i - 1];
            }

            rightProduct[size - 1] = 1;
            for(int i = size - 2; i >= 0; i--)
            {
                rightProduct[i] = rightProduct[i + 1] * array[i + 1]; 
            }

            for(int i = 0; i < size; i++)
            {
                ans[i] = leftProduct[i] * rightProduct[i];
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("{0} ", ans[i]));
            }
        }
        public static void FindProductArray()
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
            Console.WriteLine("\n");

            PrintProduct(array, size);
        }
    }
}
