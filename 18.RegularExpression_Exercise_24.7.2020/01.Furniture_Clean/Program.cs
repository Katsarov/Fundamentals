﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture_Clean
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            double totalPrice = 0;

            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            while (input != "Purchase")
            {
                Match match = Regex.Match(input,pattern);

                if (match.Success)
                {
                    furniture.Add(match.Groups[1].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
