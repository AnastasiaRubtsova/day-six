using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); 

        bool dividedByTwo = number % 2 == 0;
        bool dividedByTen = number % 10 == 0;

        if (dividedByTwo && dividedByTen)
        {
            Console.WriteLine("the number is even and divisible by ten: ");
        }
        else
        {
            Console.WriteLine("this number is either odd or not divisible by ten: ");
        }
    }
}