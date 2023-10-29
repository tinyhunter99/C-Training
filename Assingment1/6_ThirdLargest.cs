using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    internal class ThirdLargest
    {
        private static int Solve(int[] array, int size)
        {
            int largest = array[0];
            for(int i = 1; i < size; i++)
            {
                largest = Math.Max(array[i], largest);
            }


            int secondLargest = int.MinValue;
            for(int i = 0; i < size; i++)
            {
                if (array[i] > secondLargest && array[i] < largest && secondLargest != largest)
                {
                    secondLargest = array[i];
                }
            }

            int thirdLargest = int.MinValue;
            for(int i = 0; i < size; i++)
            {
                if (array[i] > thirdLargest && array[i] < secondLargest && thirdLargest != secondLargest)
                {
                    thirdLargest = array[i];
                }
            } 

            return thirdLargest;
        }
        public static void FindThirdLargest()
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

            if(size < 3)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            int ans = Solve(array, size);
            Console.WriteLine(String.Format("\nThe Third Largest element in the array is : {0}", ans));
        }
    }
}
