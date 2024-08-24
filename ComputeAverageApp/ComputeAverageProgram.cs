using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
     class ComputeAverageProgram 
    {
        static void Main(string[] args)
        {
            // initialize the array for user input grade
            double[] input = new double[5];
            Console.WriteLine(DateTime.Now.ToString("\t\t\tMM/dd/yyyy"));

            Console.WriteLine("=============>>  Compute Average Grade App  <<=============== ");
            Console.WriteLine("Enter 5 grades seperated by new line: ");
            
            //looping to stored the  5 grades data to compute average 
            for (int x = 0; x < input.Length; x++)
            {//storing the user input 5 times in array
                int num = x + 1;
                Console.Write(num + ". " );
                input[x] = Convert.ToDouble(Console.ReadLine());Console.Beep();               
            }
            //Computing average by adding all input, then divide it by 5 and round off using Math class
           double TotalSum = input[0] + input[1] + input[2] + input[3] + input[4];
           double Average = TotalSum / 5;
           int RoundOff = Convert.ToInt32(Math.Round(Average));
            // The output
            Console.WriteLine("============================");Console.Beep();
            Console.WriteLine("The average is " + Average + " and round off to " + RoundOff );
            Console.WriteLine("Thank you! ^-^");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
