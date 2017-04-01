using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var first = input[0];
            input.Reverse();
            var last = input[0];
            input[0] = first;
            input.Reverse();
            input[0] = last;
            input.Reverse();
            
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
