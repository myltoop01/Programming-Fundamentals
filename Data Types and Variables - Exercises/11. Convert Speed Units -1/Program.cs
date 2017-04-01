using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units__1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint distanceInMeters = uint.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            ushort time = (ushort)(hours * 3600 + minutes * 60 + seconds);
            float metersPerSecond = (float)distanceInMeters / time;
            Console.WriteLine("{0:0.#######}", (metersPerSecond));
            float kmPerHours = (float)distanceInMeters / 1000 / ((float)time / 3600);
            Console.WriteLine("{0:0.#######}", kmPerHours);
            float milesPerHour = (float)(distanceInMeters) / 1609 / ((float)time / 3600);
            Console.WriteLine("{0:0.#######}", milesPerHour);
        }
    }
}
