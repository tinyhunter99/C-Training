using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    internal class MinimumGap
    {
        private static bool IsPerfectSquare(int num)
        {
            return Math.Ceiling((double)(Math.Sqrt(num))) == Math.Floor((double)(Math.Sqrt(num)));
        }
        private static int Solve(int num)
        {
            if(IsPerfectSquare(num))
            {
                return 0;
            }
            
            int high, low;
            int temp = num + 1;
            while (true)
            {
                if(IsPerfectSquare(temp))
                {
                    high = temp;
                    break;
                }
                temp++;
            }

            temp = num - 1;
            while (true)
            {
                if (IsPerfectSquare(temp))
                {
                    low = temp;
                    break;
                }
                temp--;
            }

            return Math.Min(high - num, num - low);
        }
        public static void FindMinimumGap()
        {
            int num;
            Console.Write("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            int ans = Solve(num);

            Console.WriteLine(String.Format("The minimum gap to make {0} a perfect square is {1}", num, ans));
        }
    }
}
