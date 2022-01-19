using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
     class LeapYear
    {
       public static void LeapYearProgram()
        {
            Console.Write("Enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year  %  4  == 0) && (year % 100 != 0) || (year % 400 == 0))
                    Console.WriteLine( year + " is leap year " );
            else
                Console.WriteLine(year + " is not leap year");
        }
    }
}
