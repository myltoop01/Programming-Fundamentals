using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());
            int minValuebetweenAandB = GetMin(numberA, numberB);
            int minValuebetweenAandBandC = Math.Min(minValuebetweenAandB, numberC);
            Console.WriteLine(minValuebetweenAandBandC);
        }
        static int GetMin(int a, int b)
        {
            int minValue = Math.Min(a, b);
            return minValue;
        }
    }
}
