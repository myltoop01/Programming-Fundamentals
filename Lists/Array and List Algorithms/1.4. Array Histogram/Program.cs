using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<string> inputWord = new List<string>();
            List<int> count = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (inputWord.Contains(input[i]))
                {
                  //  int wordIndex = inputWord.IndexOf(input[i]);
                    count[inputWord.IndexOf(input[i])]++;
                }
                else
                {
                    inputWord.Add(input[i]);
                    count.Add(1);
                }
             }
            
            bool hasSwapped = true;
            while (hasSwapped)
               
            {
                hasSwapped = false;
                for (int i = 0; i < count.Count - 1; i++)
                {
                    if (count[i] < count[i + 1])
                    {
                        int temp = count[i];
                        count[i] = count[i + 1];
                        count[i + 1] = temp;

                        string tempword = inputWord[i];
                        inputWord[i] = inputWord[i + 1];
                        inputWord[i + 1] = tempword;
                        hasSwapped = true;
                    }
                }
            }
            for (int i = 0; i < count.Count; i++)
            {
                double persent = (double)((count[i] * 100.0) / input.Length); 
                Console.WriteLine("{0} -> {1} times ({2:f2}%) ", inputWord[i], count[i], persent);

            }
            
        }
    }
}
