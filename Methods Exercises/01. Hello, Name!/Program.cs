using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string nameFromMetod = GetName(name);
            Console.WriteLine("Hello, {0}!", nameFromMetod);

        }
        static string GetName(string name)
        {

            return name;
        }
    }
}
