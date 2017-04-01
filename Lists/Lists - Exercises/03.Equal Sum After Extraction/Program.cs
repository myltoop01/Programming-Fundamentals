using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var intput1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var intput2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (var item in intput1)
            {
                intput2.Remove(item);
            }
            var sum1 = intput1.Sum();
            var sum2 = intput2.Sum();
            var diff = Math.Abs(sum1 - sum2);
            if(sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
