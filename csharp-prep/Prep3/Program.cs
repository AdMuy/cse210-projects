using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumb = randomGenerator.Next(1, 100);
        
        int answer = -1;

        do {
            Console.Write("What is your guess?  ");
            answer = int.Parse(Console.ReadLine());

            if (magicNumb > answer)
            {
                Console.WriteLine("Go higher.");
            }
            else if (magicNumb < answer)
            {
                Console.WriteLine("Go lower.");
            }
            else
            {
                Console.WriteLine("That's the number.");
            }
        } while (answer != magicNumb);
    }
}