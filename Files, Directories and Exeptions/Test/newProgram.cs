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
            string[] test = File.ReadAllLines("../../Program.cs");
           
            File.WriteAllLines("../../newProgram.cs",test);

        }
    }
}
