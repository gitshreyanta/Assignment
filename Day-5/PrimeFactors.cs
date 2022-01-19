using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class FactorialExample
    {
        public void PrimeFactors (int num)
        {
           while (num % 2 == 0)
            {
                Console.Write(2 + " ");
                num =  num/2;
            }
              Console.WriteLine(num); 
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num = num/i;
                }
            }
            if (num > 2)
                Console.Write(num);
        }
        public void Main()
        {
           
            Console.Write("Enter the number: " );
            int number = Convert.ToInt32(Console.ReadLine());
            PrimeFactors(number);

        }

    }
}