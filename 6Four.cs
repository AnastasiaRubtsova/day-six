using System;

class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a positive number a (to complete, type a negative number): ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out a))
            {
                if (a > 0)
                {
                    int sum = 0;
                    int number;
                    Console.WriteLine("Enter a positive number ");
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            if (number < 0)
                            {
                                break;
                            }
                            if (number % a == 0)
                            {
                                sum += number;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input error, try again...");
                        }
                    }
                    Console.WriteLine("The sum of numbers divisible by a positive number without remainder: " + sum);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a positive number a:");
                }
            }
            else
            {
                Console.WriteLine("Input error, enter a positive integer... ");
            }
        }
    }
}