using System;
using System.Collections.Generic;
class Program //This is where we bring everything together so that the user can interact with the console.
{
    static void Main(string[] args)
    {
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

            input = Console.ReadLine();
            if (input.ToLower() != "quit")
            {
                scriptures.HideRandomWords(3);// hide 3 words per turn
            }
        }
        //end
        Console.Clear();
        /*scripture es un objeto.
        GetDisplayText() es un método que devuelve un texto (string).
        Console.WriteLine() imprime ese texto en la consola y luego hace 
        un salto de línea.*/
        Console.WriteLine(scriptures.GetDisplayText());
        Console.WriteLine("\nProgram END.........");
    }
}