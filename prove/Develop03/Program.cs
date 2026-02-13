using System;
using System.Collections.Generic;
class Program //This is where we bring everything together so that the user can interact with the console.
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // 1. Inicialización
        Reference reference = new Reference("Proverb", 3, 5);
        Scriptures scriptures = new Scriptures(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        string input = " ";
        
        // 2. Ciclo principal
        while (input.ToLower() != "quit" && !scriptures.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scriptures.GetDisplayText());
            //user input
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to finish: ");
            
        }


    }
}