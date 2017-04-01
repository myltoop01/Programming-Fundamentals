using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var banedWord = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            foreach(var word in banedWord)
            {
                text = text.Replace(word,new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
        
    }
}
