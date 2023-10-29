using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    internal class MagicalString
    {
        private static bool IsMagical(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += (num % 10);
                num /= 10;
                if(num == 0 && sum > 9)
                {
                    num = sum;
                    sum = 0;
                } 
            }
            return sum == 1;
        }
        public static void IsMagicalString()
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            int num;
            if(int.TryParse(str, out num))
            {
                if (IsMagical(num))
                {
                    Console.WriteLine("Yes, the input string is magical");
                }
                else
                {
                    Console.WriteLine("Input string is not magical");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
