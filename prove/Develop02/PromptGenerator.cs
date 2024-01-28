using System.Collections.Generic;
using System;
using System.IO; 
// Creates a class to generate a random prompt so the user can
// respond to that prompt. 
public class PromptGenerator
{
    // A list is created for the random prompts
    public List<string> _prompts = new List<string>();
    // A method is created to retrieve and return
    // a random prompt from a text file. 
    public string GetRandomPrompt()
    {
        string[] _prompts = File.ReadAllLines("prompts.txt");
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count());
        return _prompts[index];
    }
}