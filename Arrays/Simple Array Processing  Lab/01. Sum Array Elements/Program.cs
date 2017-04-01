using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            var sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                sum += input[i];
                
                
            }
            Console.WriteLine(sum);
        }
    }
}
