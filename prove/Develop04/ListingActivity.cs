using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0) // You may want to set a default duration or pass it as a parameter
    {}
    public void Run()
    {
        DisplayStartingMessage(); //method herencia
        Random random = new Random(); //chose a random topic
        Console.WriteLine("\nThink about next topic.");
        Console.WriteLine($"---{_prompts[random.Next(_prompts.Count)]}---");

        Console.WriteLine("Start in: ");
        ShowCountDown(5); // 5 seconds to think
        _count = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); //time requested by user

        //Loop to capture entries until time runs out
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine(); //user types something
            _count++; //the counter sum
        }
        Console.WriteLine($"element {_count} list");
        DisplayEndingMessage(); // end inherited message

    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! You have completed the Listing Activity.");
    }
}