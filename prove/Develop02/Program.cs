using System;

class Program
{
    static void Main(string[] args)
    {        
        PromptGenerator generator = new PromptGenerator();
        Journal journal1 = new Journal();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        int option = -1;

        do 
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Entry newEntry = new Entry();
                newEntry._promptText = generator.GetRandomPrompt();
                Console.WriteLine($"{newEntry._promptText}");
                newEntry._entryText = Console.ReadLine();
                newEntry._date = dateText;
                journal1.AddEntry(newEntry);
            }

            else if (option == 2)
            {
                journal1.DisplayAll();
            }

            else if (option == 3)
            {
                Entry newEntry = new Entry();
                Console.Write("What is the name of the file? ");
                
                journal1 = journal1.LoadFromFile(Console.ReadLine());
                
            }

            else if (option == 4)
            {
                Console.Write("What is the name of the file? ");
                journal1.SaveToFile(Console.ReadLine());
            }
        } while (option != 5);

    }
}