using System;

class Program
{
    static void Main(string[] args)
    {
        // Calls most of the classes we're going to use in the program.
        PromptGenerator generator = new PromptGenerator();
        Journal journal1 = new Journal();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        int option = -1;
        //Strats the loop by asking the user to select an option.
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
            // The user will be able to add a new entry to their journal based on their response
            // to the random prompt given. 
            if (option == 1)
            {
                Entry newEntry = new Entry();
                newEntry._promptText = generator.GetRandomPrompt();
                Console.WriteLine($"{newEntry._promptText}");
                newEntry._entryText = Console.ReadLine();
                newEntry._date = dateText;
                journal1.AddEntry(newEntry);
                Console.WriteLine($"------------------------------------");
                Console.WriteLine($"Entry has been added to your journal");
                Console.WriteLine($"------------------------------------");
            }
            // The user can display all of the entries in their journal.
            else if (option == 2)
            {
                journal1.DisplayAll();
                Console.WriteLine($"------------------------------------");
                Console.WriteLine($"Entries displayed successfully.");
                Console.WriteLine($"------------------------------------");
            }
            // The user can load a file with previous entries with the
            // file name. These entries will be added to the journal and the can
            // be displayed.
            else if (option == 3)
            {
                Console.Write("What is the name of the file? ");
                journal1 = journal1.LoadFromFile(Console.ReadLine());
                Console.WriteLine($"------------------------------------");
                Console.WriteLine("The file has been successfully loaded.");
                Console.WriteLine($"------------------------------------");   
            }
            // The user can save a file with all the entries in their journal.
            // They can input the filename they want. 
            else if (option == 4)
            {
                Console.Write("What is the name of the file? ");
                journal1.SaveToFile(Console.ReadLine());
                Console.WriteLine($"------------------------------------");
                Console.WriteLine("The file has been successfully saved.");
                Console.WriteLine($"------------------------------------");
            }
        // The program will be closed.
        } while (option != 5);
    }
}