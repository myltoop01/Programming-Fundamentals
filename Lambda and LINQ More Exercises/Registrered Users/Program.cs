using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registrered_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> registeredUsername = new Dictionary<string, DateTime>();
            string inputLine = Console.ReadLine();
            while(inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string userName = inputParams[0];
                DateTime registryDate = DateTime.ParseExact(inputParams[1],"dd/MM/yyyy",CultureInfo.InvariantCulture);
                registeredUsername.Add(userName, registryDate);
                inputLine = Console.ReadLine();
            }
            Dictionary<string, DateTime> orderedUsers = registeredUsername
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach(var orderedUserName in orderedUsers)
            {
                Console.WriteLine("{0}",orderedUserName.Key);
            } 
            
        }
    }
}
