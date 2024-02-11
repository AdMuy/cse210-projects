using System;

class Program
{
    static void Main(string[] args)
    {
        bool finish = false;
        Scripture newScripture = new Scripture(new Reference("1 Nephi", 2, 15), "And my father dwelt in a tent.");
        Console.WriteLine($"{newScripture.GetDisplayText()}\n");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string input = Console.ReadLine();
        do
        {
        Console.Clear();
        newScripture.HideRandomWords(3);
        Console.WriteLine($"{newScripture.GetDisplayText()}");
        finish = newScripture.IsCompletelyHidden();
        Console.WriteLine($"{finish}");
        input = Console.ReadLine();
        }
        
        while (input != "quit" ^ finish == true);
    }
}