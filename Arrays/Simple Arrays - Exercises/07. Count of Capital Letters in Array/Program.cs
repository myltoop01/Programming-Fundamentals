using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                    if (currentWord.Length == 1)
                {
                    char character = currentWord[0];
                    if(character >= 'A' && character <= 'Z')
                    {
                        count += 1;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
