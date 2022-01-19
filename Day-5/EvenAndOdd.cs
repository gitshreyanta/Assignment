using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   class EvenAndOdd 
    {
        public static void EvenAndOddProgram()
        {
            Console.WriteLine("Enter the Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Print the Even" + num1);
            }
            else
            {
                Console.WriteLine("Print the odd " + num1);
            }
                
            
        }
    }
}
