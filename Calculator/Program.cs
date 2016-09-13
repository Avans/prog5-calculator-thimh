using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeCalc calcy = new AgeCalc();

            DateTime result;
            
            bool successfull = false;

            while (successfull == false)
            {
                Console.WriteLine("Please enter your date of birth:");
                string input = Console.ReadLine();
                bool success = DateTime.TryParse(input, out result);
                if (success)
                {
                    if (result.CompareTo(DateTime.Now) == -1)
                    {
                        Console.WriteLine("Your age is: " + calcy.CalculateAge(result) + ".");
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to close this window.");
                    }
                    successfull = true;
                }
                else
                {
                    Console.WriteLine("Your input format is invalid, it should be dd-mm-yyyy.");
                    Console.WriteLine("");
                }
            }
            Console.Read();
        }
    }
}
