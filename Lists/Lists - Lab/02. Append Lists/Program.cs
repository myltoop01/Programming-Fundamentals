using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            var results = new List<string>();
            input.Reverse();
            foreach(var token in input)
            {
                string[] number = token.Split(' ');
                foreach(var item in number)
                {
                    if(item != "")
                    {
                        results.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
