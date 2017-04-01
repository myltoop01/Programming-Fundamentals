using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            var largest = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                if (input[i] > largest)
                {
                    largest = input[i];
                }
            }
            Console.WriteLine(largest);
        }
    }
}
