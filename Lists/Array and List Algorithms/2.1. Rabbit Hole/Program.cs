using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            int index = 0;
            bool diedFromBomd = false;
            while (energy > 0)
            {
                string[] comand = input[index].Split('|');
                string currentComand = comand[0];
                if (currentComand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                int value = int.Parse(comand[1]);
                diedFromBomd = false;
                switch (currentComand)
                {
                    case "Left":
                        index = Math.Abs(index - value)% input.Count;
                        energy -= value;
                        break;
                    case "Right":
                        index = (index + value) % input.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        input.RemoveAt(index);
                        index = 0;
                        energy -= value;
                        diedFromBomd = true;
                        break; 
                }
                if (input[input.Count-1] != "RabbitHole")
                {
                    input.RemoveAt(input.Count - 1);
                }                
                input.Add("Bomb|" + energy);
            }
            if ( energy <= 0 && diedFromBomd)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if (energy <= 0 && !diedFromBomd)
            {
                Console.WriteLine ("You are tired. You can't continue the mission.");
            }
        }
    }
}
