using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var buidings = Console.ReadLine().Split().Select(int.Parse).ToList();
            var camileback = int.Parse(Console.ReadLine());
            if (buidings.Count == camileback)
            {
                Console.WriteLine("already stable: "+string.Join(" ",buidings));
                return;
            }
            var rounde = 0;
            while(buidings.Count > camileback)
            {
                buidings.RemoveAt(0);
                buidings.RemoveAt(buidings.Count-1);
                rounde++;
            }
            Console.WriteLine($"{rounde} rounds");
            Console.WriteLine("remaining: "+string.Join(" ", buidings));
        }
    }
}
