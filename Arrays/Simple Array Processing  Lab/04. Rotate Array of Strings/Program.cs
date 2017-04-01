using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] rotatetArrey = new string [input.Length];
            rotatetArrey[0] = input[input.Length-1];
            for (int i = 0; i < input.Length-1; i++)
            {
                rotatetArrey[i+1] = input[i];
            }
            Console.WriteLine(string.Join(" ",rotatetArrey));

        }
    }
}
