using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class QuotAndRem
    {
        public static void QuotientAndRemainder()
        {
            Console.Write("Enter the dividend : " );
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Divisor : " );
            int divisor =  Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;

            Console.WriteLine("Quotient =" + quotient);
            int remainder = dividend % divisor;
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
