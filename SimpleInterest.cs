using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double principal;
            Console.Write("Enter the principal amount : ");
            var inputPrincinpal = Console.ReadLine();
            if (double.TryParse(inputPrincinpal, out principal))
            {
                Console.WriteLine(String.Format("Your Principal Amount is : {0}", principal));
            }
            else
            {
                Console.WriteLine("Invalid Principal Amount, Please try again");
            }

            double rateOfInterest;
            Console.Write("Enter the Rate of Interest : ");
            var inputRateOfInterest = Console.ReadLine();
            if (double.TryParse(inputRateOfInterest, out rateOfInterest))
            {
                Console.WriteLine(String.Format("Your Rate of Interest is : {0}", rateOfInterest));
            }
            else
            {
                Console.WriteLine("Invalid Rate of Interset, Please try again");
            }

            double time;
            Console.Write("Enter the time in years : ");
            var inputTime = Console.ReadLine();
            if (double.TryParse(inputTime, out time))
            {
                Console.WriteLine(String.Format("Your Time in years : {0}", time));
            }
            else
            {
                Console.WriteLine("Invalid Time, Please try again");
            }

            double simpleInterest = (principal * rateOfInterest * time) / 100;
            Console.WriteLine(String.Format("The simple Interest is : {0}", simpleInterest));

            Console.ReadKey();
        }
    }
}
