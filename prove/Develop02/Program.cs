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
            Console.Write("\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n ");
            Console.WriteLine("What would you like to do?");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
//Use the PromptGenerator class to get a random question.

                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.WriteLine("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString();

                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _promptText = prompt,
                        _entryText = response
                    };
                    journal.AddEntry(newEntry);
                    break;
//Call the DisplayAll() method of the Journal class, which is responsible for printing all stored entries.
                    case 2:
                    journal.DisplayAll();
                    break;
//(Cases 3 and 4): Prompts the user for a file name and uses theJournal methods to interact with the hard drive.
                    case 3:
                    Console.WriteLine("File name: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;

                    case 4:
                    Console.Write("File name to save: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename); //it will create .txt file
                    break;
                }

            }


        }
    }
}
//GetRandomPrompt(): Uses the Random class in C# to select a random index from the list.
