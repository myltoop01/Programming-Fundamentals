using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinatesXandY = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string[] sequenceCommands = Console.ReadLine().Split(' ').ToArray();
            int x = coordinatesXandY[0];
            int y = coordinatesXandY[1];
            int planeX = 0;
            int planeY = 0;
            for (int i = 0,j=1; i < sequenceCommands.Length; i++,j++)
            {
                if (sequenceCommands[i].Contains("up"))
                {
                    planeY += int.Parse(sequenceCommands[j]);
                }
                else if (sequenceCommands[i].Contains("down"))
                {
                    planeY -= int.Parse(sequenceCommands[j]);
                }
                else if (sequenceCommands[i].Contains("left"))
                {
                    planeX -= int.Parse(sequenceCommands[j]);
                }
                else if (sequenceCommands[i].Contains("right"))
                {
                    planeX += int.Parse(sequenceCommands[j]);
                }
            }
            
            if(x==planeX && y == planeY)
            {
                Console.WriteLine($"firing at [{x}, {y}]");
                Console.WriteLine("got 'em!");

            }
            else
            {
                Console.WriteLine($"firing at [{planeX}, {planeY}]"); 
              Console.WriteLine(" better luck next time...");
                
            }
        }
    }
}
