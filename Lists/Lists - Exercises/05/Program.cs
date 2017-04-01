﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstHalf = input.Take(input.Length / 2).ToArray();
            var secondHalf = input.Skip(input.Length / 2).ToArray();
            var lenght = input.Length + (input.Length / 2);
            var result = new List<int>(lenght);


            for (int i = 0; i < firstHalf.Length; i++)
            {
                result.Add(secondHalf[i] / 10);
                result.Add(firstHalf[i]);
                result.Add(secondHalf[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
