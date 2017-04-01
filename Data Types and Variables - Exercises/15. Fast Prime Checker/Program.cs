using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int primeChecker = 2; primeChecker <= numbers; primeChecker++)
            {
                bool result = true;
                for (int i = 2; i <= Math.Sqrt(primeChecker); i++)
                {
                    if (primeChecker % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
                Console.WriteLine($"{primeChecker} -> {result}");
            }
            

        }
    }
}
