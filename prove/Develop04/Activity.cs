using System;

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the activity {_name}");
        Console.WriteLine($"\n {_description}");
        Console.WriteLine($"How many time must delay? {_duration}");

        Console.Clear();
        Console.WriteLine("Start");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>{"|", ":(", ":)", ";)"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animation[i].ToString();
            Console.WriteLine(s);
            Thread.Sleep(250);
            Console.WriteLine("\b \b"); //to delete the last character
            i++;
            if (i >= animation.Count) i = 0;
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i < 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }


}

