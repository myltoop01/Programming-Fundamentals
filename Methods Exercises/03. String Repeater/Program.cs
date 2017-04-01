using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numer = int.Parse(Console.ReadLine());
            RepeatString(input,numer);
        }
        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
            Console.WriteLine();
            return repeatedString;
        }

    }
}
