using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool increasing = false;
            for (int i = input.Length-1 ; i >= 0; i--)
            {
                if (i > 0)
                {
                    if (input[i] > input[i - 1])
                    {
                        increasing = true;

                    }
                    else increasing = false;
                    if (increasing == false)
                    {
                        Console.WriteLine("No");
                        break;
                    }
                    
                 }
            }
            if (increasing == true)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
