using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ( input[i] == n)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
