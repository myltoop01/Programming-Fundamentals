using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < n; i++)
            {
                string inputFirst = (Console.ReadLine());
                { 
                if (inputFirst == "success" || inputFirst == "error")
                       {
                        
                      string inputsecond = (Console.ReadLine());
                      var inputthird = (Console.ReadLine());
                        {

                            if (inputFirst == "success")
                            {

                                ShowSuccess(inputsecond, inputthird);
                            }
                            if (inputFirst == "error")
                            {
                                var convert = (int.Parse)(inputthird);
                                ShowError(inputsecond, convert);
                            }
                        }
                     }
               
               }
            }
           
        }
     static string ShowSuccess(string operation, string message)
         {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
            return ("") ;
         }
     static string ShowError(string operation, int code)
        {

            if (code > 0)
            {

                string reason = ("Invalid Client Data");
            
            Console.WriteLine($"Error: Failed to execute { operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
           }
           else if (code < 0)
            {

                string reason = ("Internal System Failure");

                Console.WriteLine($"Error: Failed to execute { operation}.");
                Console.WriteLine("==============================");
                Console.WriteLine($"Error Code: {code}.");
                Console.WriteLine($"Reason: {reason}.");
            }
            return ("");
        }

    }
}
