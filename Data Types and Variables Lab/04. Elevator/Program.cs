using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double course = numberOfPeople/capacity;
            if (numberOfPeople % capacity == 0) 
            {
                Console.WriteLine(course);
            }
            else
            {
                Console.WriteLine("{0}",(int)Math.Ceiling((double)numberOfPeople/capacity));
            }
            
            
        }
    }
}
