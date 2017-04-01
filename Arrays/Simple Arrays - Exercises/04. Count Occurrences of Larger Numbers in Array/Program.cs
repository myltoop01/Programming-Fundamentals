using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double number = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] > number)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
