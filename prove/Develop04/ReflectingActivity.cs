using System.Collections.Generic;
using System;
using System.IO; 
public class ReflectingActivity
{
    List<string> _prompts;
    List<string> _questions;

    public ReflectingActivity()
    {

    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        string[] _prompts = File.ReadAllLines("reflectionsprompts.txt");
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count());
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        string[] _prompts = File.ReadAllLines("reflectionsquestions.txt");
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count());
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetRandomPrompt()}");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }
}