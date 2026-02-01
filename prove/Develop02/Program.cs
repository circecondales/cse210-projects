using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Journal journal= new Journal();
        PromptGenerator promptGenerator= new PromptGenerator();
        int choice = -1;

        Console.WriteLine("Welcome to Journal Program");

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.Write("\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            Console.WriteLine("What would you like to do?");

            if (int.Parse(Console.Readline(), out choice))
            {
                switch (choice)
                {
                    case 1:
                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine(prompt);
                    Console.WriteLine("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString();

                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _promptText = prompt,
                        _entryTex = response
                    };
                    journal.AddEntry(newEntry);
                    break;

                    case 2:
                    journal.DisplayAll();
                    break;

                    case 3:
                    Console.WriteLine("File name: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;

                    case 4:
                    Console.WriteLine("File name: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                }

            }


        }
    }
}