using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] altitudeChange = Console.ReadLine().Split(' ').ToArray();
            long currentAltitude = long.Parse(altitudeChange[0]);
            for (int i = 1, j = 2; i < altitudeChange.Length; i++, j++)
            {
                if (altitudeChange[i].Contains("up"))
                {
                    currentAltitude += int.Parse(altitudeChange[j]);
                }
                else if (altitudeChange[i].Contains("down"))
                {
                    currentAltitude -= int.Parse(altitudeChange[j]);
                }
            }
                if (currentAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                }
                else
                {
                    Console.WriteLine($"got through safely. current altitude: {currentAltitude}m");
                }
            
        }
    }
}
