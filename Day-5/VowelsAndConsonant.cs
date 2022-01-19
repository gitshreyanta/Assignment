using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Alphabet
    {
        public static void VowelsAndConsonant()
        {
            char alphabet;
            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            int i = alphabet;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (alphabet)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
