using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private string[] _prompts;
    private List<string> _responses;

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths you have?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "What are things you are grateful for?",
            "What are things that make you happy?",
            "Who are people you admire?",
            "Who are some of your personal heroes?"
        };

        _responses = new List<string>();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Length);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[promptIndex]} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine();

        _responses.Clear();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _responses.Add(response);
            }
        }

        stopwatch.Stop();

        Console.WriteLine();
        Console.WriteLine($"You listed {_responses.Count} items!");
        DisplayEndingMessage();
    }
}