using System.Collections.Generic;
using System.Linq;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        60) // You can change 60 to your desired default duration in seconds
    {}

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.Write("Breathe out...");
            ShowCountDown(4);
        }

        //DisplayEndingMessage();
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! You have completed the Breathing Activity.");
    }

}