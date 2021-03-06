﻿using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(isPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool isPalindrome(string text)
        {
            var reversed = text.Reverse().ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (!(reversed[i] == text[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
