using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    
    
        class Program
        {
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();

                int sumInt = calculator.Add(10, 20);
                double sumDouble = calculator.Add(15.5, 20.3);
                int sumThreeInts = calculator.Add(5, 10, 15);

                Console.WriteLine($"Sum of two integers: {sumInt}");
                Console.WriteLine($"Sum of two doubles: {sumDouble}");
                Console.WriteLine($"Sum of three integers: {sumThreeInts}");

                Console.ReadKey();
            }
        }

        
    }


