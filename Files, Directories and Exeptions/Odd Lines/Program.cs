using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] text = File.ReadAllLines("input.txt");

            File.WriteAllLines("output.txt",
                                     text.Where((line, index) => index % 2 == 1));

        }
    }
}
