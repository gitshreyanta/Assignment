using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Harmonic
    {
        public static void HarmonicFunction()
        {
            Console.WriteLine("Enter the Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            double Result = 0;
            if (num != 0)
            {
                for (int i = 1; i <=num; i++)
                {
                    
                    Result = Result + (double)1/i;
                }
                Console.WriteLine("Harmonic Result: " + Result);
            }
            else
            {
                Console.WriteLine("enter the number greater than zero");
            }
            
        }


    }
}
