﻿using System;
using System.Linq;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            // Прочитаме си входния стринг
            string password = Console.ReadLine();

            // Прочитаме си командата
            string command = Console.ReadLine();

            while (command != "Done")
            {

                if (command.Contains("TakeOdd"))
                {
                    StringBuilder oddChars = new StringBuilder();
                    for (int i = 1; i < password.Length; i+=2)
                    {
                        oddChars.Append(password[i]);
                        
                    }
                    password = oddChars.ToString();
                    Console.WriteLine(password);
                }

                if (command.Contains("Cut"))
                {
                    var splitted = command.Split();
                    int index = int.Parse(splitted[1]);
                    int length = int.Parse(splitted[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }

                if (command.Contains("Substitute"))
                {
                    var splitted = command.Split();
                    string oldSubstr = splitted[1];
                    string newSubstr = splitted[2];

                    if (password.Contains(oldSubstr))
                    {
                        password = password.Replace(oldSubstr, newSubstr);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: { password}");
        }
    }
}
