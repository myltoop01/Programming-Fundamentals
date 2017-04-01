using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string inputLine = Console.ReadLine();
            int lastRemuved = -1;
           
            string outPut = "";
            while (inputLine != "stop")
            {
                if(inputLine == "bang")
                {
                    if(numbers.Count == 0)
                    {
                        outPut = "nobody left to shoot! last one was {0}";
                        break;
                    }
                    int sum = SumElements(numbers);
                    double average = (double)sum / numbers.Count;
                    lastRemuved = ShotElements(numbers, average);
                    DecrementElements(numbers);
                   
                }
                else
                {
                    int number = int.Parse(inputLine);
                    numbers.Insert(0, number);
                }
                 inputLine = Console.ReadLine();
            }
            if (numbers.Count > 0 && outPut == "")
            {
                Console.WriteLine("survivors: {0}",string.Join(" ",numbers));
            }
            else if (numbers.Count == 0 && outPut == "")
            {
                Console.WriteLine($"you shot them all. last one was {lastRemuved}");
            }
            else
            {
                Console.WriteLine(outPut,lastRemuved);  
            }

            
        }

        private static void DecrementElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

         static int ShotElements (List<int> numbers, double average)
        {
            int result = -1;
            if (numbers.Count == 1)
            {
                Console.WriteLine("shot {0}", numbers[0]);

                result = numbers[0];
                numbers.RemoveAt(0);
                return result;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < average)
                {
                   
                    Console.WriteLine("shot {0}", numbers[i]);
                    
                    result = numbers[i];
                    numbers.RemoveAt(i);
                    break;
                    
                }
            }
            return result; 
        }

        static int SumElements (List<int> numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
