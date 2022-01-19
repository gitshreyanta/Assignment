using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class FlipCoin
    {
        public static void FindFLipCoinPercentage()
        {
            int tailCount = 0;
            int headCount = 0;
            Console.WriteLine("Enter the number to know how many times to flip the coin");
            int numOfTimes = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < numOfTimes; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue < 0.5) tailCount++;
                else 
                    headCount++;
            }
            Console.WriteLine("Numbers of  tails count is " + tailCount + " out of " + numOfTimes);
            Console.WriteLine("Numbers of  heads count is " + headCount + " out of " + numOfTimes);


            double tailPercentage=(double) (tailCount * 100) / numOfTimes;
            Console.WriteLine("Tail Percentage : " + tailPercentage);
            double headPercentage = (double)(headCount * 100) / numOfTimes;
            Console.WriteLine("Head Percentage : " + headPercentage);
        }
    }
}
