using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Sandbox World!");
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        //Console.Write("What is your last name? ");
        //string fName = Console.ReadLine();

        //Console.WriteLine($"Your name is {lName}, {fName} {lName}.");
        Random RandomGeneration = new Random();
        int magicNumber = RandomGeneration.Next(1,101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if(magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess it");
            }
        }

    }
}