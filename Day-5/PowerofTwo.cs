using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Poweroftwo
    {
        static public void PowerofTwoProgram()
        {
            Console.Write("Enter the Nubmer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the power: ");
            int pow = Convert.ToInt32(Console.ReadLine());
            double pow_ab = Math.Pow(num , pow);
            Console.WriteLine(num + " Power of  " +pow + " is " + pow_ab);
            
        }
            
    }
}
