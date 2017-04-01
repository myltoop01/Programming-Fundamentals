using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> bankAndAccounds
             = new Dictionary<string, Dictionary<string, decimal>>();
            string inputLine = Console.ReadLine();
            while(inputLine!="end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions
                .RemoveEmptyEntries);
                string bankName = inputParams[0];
                string account = inputParams[1];
                decimal balance = decimal.Parse(inputParams[2]);
                if (!bankAndAccounds.ContainsKey(bankName))
                    bankAndAccounds.Add(bankName, new Dictionary<string, decimal>());
                if (!bankAndAccounds[bankName].ContainsKey(account))
                {
                    bankAndAccounds[bankName].Add(account, 0);
                }
                bankAndAccounds[bankName][account] += balance;
                    inputLine = Console.ReadLine();
            }

            bankAndAccounds.OrderByDescending(bank => bank.Value.Sum(accound => accound.Value))
                .ThenByDescending(bank => bank.Value.Max(accound => accound.Value))
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(accound => accound.Value)
                .ToList()
                .ForEach(accound => Console.WriteLine("{0} -> {1} ({2})", accound.Key, accound.Value, bank.Key)));
        }
    }
}
