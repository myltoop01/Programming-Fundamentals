using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat()
            {
                Name = "Sharo",
                Age = 4,
                IsSleep = false

            };
            var anotherCat = new Cat()
            {
                Name = "Pisi",
                Age = 3,
                IsSleep = true
            };
            // cat.GoToSleep();
            Console.WriteLine(cat.IsSleep);
        }
    }
}
