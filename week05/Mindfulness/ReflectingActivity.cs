using System;
using System.Threading;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private string[] _prompts;
    private string[] _questions;

    public ReflectingActivity()
        : base("Reflecting Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something you were afraid of.",
            "Think of a time when you made someone smile."
        };

        _questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was over?",
            "What did you learn from this experience?",
            "What made this experience challenging?",
            "How did this experience help you grow?",
            "What would you do differently next time?",
            "How can you use what you learned in the future?",
            "What does this experience teach you about yourself?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Length);

        Console.WriteLine($"--- {_prompts[promptIndex]} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now reflect on each of the following questions:");
        Console.WriteLine();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            int questionIndex = random.Next(_questions.Length);

            Console.WriteLine(_questions[questionIndex]);
            ShowSpinner(5);
            Console.WriteLine();
        }

        stopwatch.Stop();

        DisplayEndingMessage();
    }
}