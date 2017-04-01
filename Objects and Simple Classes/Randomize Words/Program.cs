﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomPosition = random.Next(0, words.Length);
                var temporaryWord = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = temporaryWord;
            }
                foreach(var word in words)
                {
                    Console.WriteLine(word);
                }
            }

         
    }
}
