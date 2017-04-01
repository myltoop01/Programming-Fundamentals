﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            input.Sort();
            input.Reverse();
            
            Console.WriteLine(string.Join(" ", input.Take(n)));
        }
    }
}
