using System.Collections.Generic;
using System.Linq;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){}

    public void Run()
    {
        DateTime dateTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.Write("Breathe out...");
            ShowCountDown(4); 
        }
        DisplayEndingMessage();
    }

}