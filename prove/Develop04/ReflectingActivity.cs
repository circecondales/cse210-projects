using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?"
    };
    public ReflectingActivity() : base(
        "Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life",
        60 // You can change the default duration as needed
    ){}

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        Console.WriteLine($"\n--- {_prompts[random.Next(_prompts.Count)]}---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n> {_questions[random.Next(_questions.Count)]} ");
            ShowSpinner(4);
        }
        DisplayEndingMessage();
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! You have completed the Reflecting Activity.");
        Console.WriteLine($"You spent {_duration} seconds reflecting.");
    }
}