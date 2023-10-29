using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    class PerfectNumber
    {
        private static bool Solve(int num)
        {
            if(num == 0)
            {
                return false;
            }

            int sum = 0;
            for(int i = 1; i <= num / 2; i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }

        public static void IsPerfectNumber()
        {
            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());

            if (Solve(num))
            {
                Console.WriteLine(String.Format("Yes, {0} is a Perfect Number", num));
            }
            else
            {
                Console.WriteLine(String.Format("{0} is not a Perfect Number", num));
            }
        }
    }
}
