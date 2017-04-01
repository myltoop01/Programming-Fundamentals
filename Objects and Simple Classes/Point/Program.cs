using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
  public  class Program
    {
       public static void Main()
        {
            var firstPointsParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstPoint = new point
            {
                x = firstPointsParts[0],
                y = firstPointsParts[1],
            };
            
            var secondPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondPoint = new point
            {
                x = secondPointParts[0],
                y = secondPointParts[1],
            };
            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine("{0:F3}",result);
        }
        public static double Distance(point first, point second)
        {
            var squareX = Math.Pow(first.x - second.x, 2);
            var squareY = Math.Pow(first.y - second.y, 2);
            var result = Math.Sqrt(squareX + squareY);
                return result;
        }
    }
}
public class point
{
    public double x { get; set; }
    public double y { get; set; }

}