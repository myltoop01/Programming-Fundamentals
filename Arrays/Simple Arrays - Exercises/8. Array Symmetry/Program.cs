using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input =  Console.ReadLine().Split(' ');

            var newInput = new string [input.Length];
            newInput[0] = input[input.Length-1];
            for (int i = 1; i <= input.Length-1; i++)
            {
                 newInput[i] = input[input.Length-i-1];
            }

            for (int i = 0; i < input.Length; i++)
            {
                
                if (newInput[i] != input[i])
                {
                  
                    Console.WriteLine("No");
                    return;
                }

            }
            
            Console.WriteLine("Yes");
            }
        }
    }

