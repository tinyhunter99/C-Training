using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1
{
    internal class RemoveSpaces
    {
        private static void PrintString(string str)
        {
            string ans = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && (i + 1 < str.Length && str[i + 1] == ' '))
                {
                    continue;
                }
                else
                {
                    ans += str[i];
                }
            }
            Console.WriteLine(ans); 
        }
        public static void RemoveMultipleSpaces()
        {
            string str;
            Console.Write("Enter a string : ");
            str = Console.ReadLine();

            str = str.Trim();
            PrintString(str);
        }
    }
}
