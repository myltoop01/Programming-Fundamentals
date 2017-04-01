using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("Testova");
            File.Create("testova/tekstov.txt");

        }
    }
}
