using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var positive = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > 0)
                {
                    positive.Add(input[i]);
                }

            }
            if(positive.Count == 0)
            {
                Console.WriteLine("empty");
            }
            positive.Reverse();
            Console.WriteLine(string.Join(" ",positive));
        }
    }
}
