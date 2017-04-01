using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> lambadaExpressions = new Dictionary<string, Dictionary<string, string>>();
            string inputLine = Console.ReadLine();
            while(inputLine != "lambada")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
                if (!inputParams.Contains("dance")) 
                {
                    string selektor = inputParams[0];
                    string selektorObject = inputParams[1];
                    string property = inputParams[2];
                    if (!lambadaExpressions.ContainsKey(selektor))
                    {
                        lambadaExpressions.Add(selektor,new Dictionary<string, string>());
                    }
                    lambadaExpressions[selektor][selektorObject] = property;
                }
                else
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                        .ToDictionary(selectorObject => selectorObject.Key,
                             selectorObject => selectorObject.Key + "." + selectorObject.Value));

                }
                inputLine = Console.ReadLine();
            }
            lambadaExpressions
                .ToList()
                .ForEach(selector => selector.Value
                .ToList()
                .ForEach(selectorObject => Console.WriteLine("{0} => {1}.{2}",
                selector.Key,
                selectorObject.Key,
                selectorObject.Value)));
        }
    }
}
