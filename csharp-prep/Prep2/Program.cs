using System;

class Program
{
    static void Main(string[] args)
   {
        Console.Write("What is grade percentage in numbers? ");
        string percentage = Console.ReadLine();
        int score = int.Parse(percentage);
        string grade;

        if (score >= 90)
        {
            grade = ("A");
        }
        else if (score >= 80)
        {
            grade = ("B");
        }
        else if (score >= 70)
        {
            grade = ("C");
        }
        else if (score >= 60)
        {
            grade = ("C");
        }
        else
        {
            grade = ("F");
        }

        Console.WriteLine($"Your grade is {grade}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Keep it up and study harder.");
        }
    }
}