using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsSleep { get; set; }
        public bool IsEaten { get; set; }

        public void GoToSleep()
        {
            if (IsEaten)
            {
                IsSleep = true;
            }
        }
    }
}
