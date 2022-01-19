using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Swap2Number
    {
        public int first = 0, second = 0;
        public static int x = 0, y = 0;
        public static void ReadingInputFromUser()
        {
            Console.WriteLine("Please enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int second = Convert.ToInt32(Console.ReadLine());
            Swap2Number swap = new Swap2Number();
            swap.SwapNumbers(first, second);
        }
        public void SwapNumbers(int first, int second)
        {
            int temp = 0;
            Console.WriteLine("Before swaping : first={0} second{1}", first, second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After swaping : first={0} second{1}", first, second);
        }
    }
}
