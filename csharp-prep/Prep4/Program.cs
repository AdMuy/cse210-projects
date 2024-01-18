using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                numbers.Remove(number);
            }
        } while (number != 0);
        Console.WriteLine(numbers.Sum());
        Console.WriteLine(numbers.Average());
        Console.WriteLine(numbers.Max());
    }
}