using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference newReference = new Reference("1 Nephi", 2, 15);
        Word newWord = new Word("And my father dwelt in a tent.");
        Console.WriteLine($"{newReference.GetDisplayText()}");
        Console.WriteLine($"{newWord.GetDisplayText()}");
        Scripture newScripture = new Scripture(newReference, "And my father dwelt in a tent.");

        Console.WriteLine($"{newScripture.GetDisplayText()}");
        // Reference(string book, int chapter, int verse)
    }
}