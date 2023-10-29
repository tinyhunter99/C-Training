using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    internal class PairSum
    {
        private static void PrintPairs(int[] array, int size, int key)
        {
            Console.WriteLine("\nPairs at indices having sum less then {0}", key);
            for(int i = 0; i < size - 1; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if (array[i] + array[j] < key)
                    {
                        Console.WriteLine(String.Format("{0}, {1}", i , j));
                    }
                }
            }
        }
        public static void FindPairs()
        {
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];    
            for(int i = 0; i < size; i++)
            {
                Console.Write(String.Format("Enter the element at {0} index : ", i));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe array is : ");
            for(int i = 0; i < size; i++)
            {
                Console.Write(String.Format("{0} ", array[i]));    
            }

            int key;
            Console.Write("\n\nEnter a key value : ");
            key = Convert.ToInt32(Console.ReadLine());

            PrintPairs(array, size, key);
        }
    }
}
