
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // List and stores all 8 question prompts
    private List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing over today, what would it be?",
        "If I could change anything today, what would it be?",
        "What is something new I learned today?",
        "What am I most grateful for today?"
    };

    // Generate random numbers
    private Random _random = new Random();

    // Get a random journal prompt
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}
