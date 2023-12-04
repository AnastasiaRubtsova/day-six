using System;
using System.Collections.Generic;

class Program
{
    static void PrintArray(List<double> array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main()
    {
        Random random = new Random();
        List<double> original = new List<double>();

        for (int i = 0; i < random.Next(10, 30); i++)
        {
            double num = (random.NextDouble() - 0.5) * 20; 
            original.Add(num);
        }

        List<double> positive = new List<double>();
        List<double> negative = new List<double>();

        foreach (var number in original)
        {
            if (number > 0)
            {
                positive.Add(number);
            }
            else if (number < 0)
            {
                negative.Add(number);
            }
        }

        Console.WriteLine("original array: ");
        PrintArray(original);
        Console.WriteLine("positive numbers: ");
        PrintArray(positive);
        Console.WriteLine("negative numbers: ");
        PrintArray(negative);
    }
}