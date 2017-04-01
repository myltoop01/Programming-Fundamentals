using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
          //  var input = Console.ReadLine();
            var sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                var input = Console.ReadLine();

                for (int j = input.Length - 1; j >= 0; j--)
                {

                    sb.Append(input[j]);
                    var result = sb.ToString();
                    Console.Write(result);
                    sb.Clear();
                }
            }

           
            

        }
    }
}
