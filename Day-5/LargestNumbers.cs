using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Largest
    {
        public static void LargestNumbers()
        {
            Console.WriteLine("Enter the First  numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second numbers : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third numbers : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the greatest among three ");
                }
                else
                {
                    Console.WriteLine("The 2nd Number is the greatest among three ");

                }
            }
            else if (num2 < num3)
                Console.WriteLine("The 2nd Number is the greatest among three ");
            else
                Console.WriteLine("The 3rd Number is the greatest among three ");

        }
    }
}
