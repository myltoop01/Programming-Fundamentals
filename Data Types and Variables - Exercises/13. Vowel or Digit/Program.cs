using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbol = Convert.ToChar(Console.ReadLine());
            if (simbol == 'a' || simbol == 'e' || simbol == 'i' || simbol == 'u' || simbol == 'o')
            {
                Console.WriteLine("vowel");
            }
            else if (simbol >= '0' && simbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }


        }
    }
}
