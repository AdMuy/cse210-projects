using System.Collections.Generic;
using System;
using System.IO; 

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {
        string[] _prompts = File.ReadAllLines("prompts.txt");
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count());
        return _prompts[index];
    }
}