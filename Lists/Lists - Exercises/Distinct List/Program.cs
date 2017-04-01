using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
          
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i+1; j <= input.Count-1; j++)
                {
                    if (input[i] == input[j])
                    {
                        input.RemoveAt(j);
                        i = 0;
                    }
                    
                }
                
            }
            Console.WriteLine(string.Join(" ", input));
           
        }
    }
}
