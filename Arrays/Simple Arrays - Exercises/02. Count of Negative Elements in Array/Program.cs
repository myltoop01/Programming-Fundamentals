using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                if (input[i] < 0)
                {
                    counter += 1; 
                }
            }
            Console.WriteLine(counter);
        }
    }
}
