using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            int count = 1;
            for (int i = input.Length-1; i >0 ; i--)
            {
               
                {
                    if (input[i] == input[i - 1])
                    {
                        count += 1;
                    }
                }
            }
            int[] newCount = new int[count];
            if (newCount.Length == input.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
