using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine();
            var input = text.Split(new[] { ' ', ',', '!', '?', '.',':' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            List<string> reversedInput = input;
            reversedInput.Reverse();

              var sb = new StringBuilder();

            
            for (int i = input.Count-1; i >= 0; i--)
            {
                 sb.Append(input[i]+" " );
            }
            var sb1 = new StringBuilder();
            for (int i = sb.Length-1; i >= 0; i--)
            {
                sb1.Append(sb[i]);
            }
         
            string sb1ToString = sb1.ToString();
            List <string> newText = sb1ToString.Split(' ').ToList();
            List<string> result = new List<string> ();
            foreach(var word in reversedInput)
            {
                if (newText.Contains(word))
                {
                    result.Add(word);
                }
            }
            result.Sort();
            
            Console.WriteLine(string.Join(", ",result.Distinct()));
        }
    }
}
