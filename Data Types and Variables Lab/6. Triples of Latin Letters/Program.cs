﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    
                    for (int k = 0; k < n; k++)
                    {
                       var letter1 = (char)('a' + i);
                       var letter2 = (char)('a' + j );
                        var letter3 = (char)('a' + k);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
                }
            }
        }
    }
}
