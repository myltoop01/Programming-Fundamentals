using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = Console.ReadLine();
          
            bool trueOrNo = (Convert.ToBoolean(variable));
            if (trueOrNo == true)
            {
                Console.WriteLine("Yes");
            }
            else if (trueOrNo == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
