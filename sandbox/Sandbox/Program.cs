using System.Collections.Generic;
using System.Linq; //necesario para usar suma

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
        List<int> userList= new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished ");
            if (int.TryParse(Console.ReadLine))
            {
                if (userNumber > 0)
                {
                    userList.Add(userNumber);
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine(" Enter a valid umber: ");
            }
// Verificamos si la lista tiene elementos antes de procesar
        }
        if (userNumber > 0)
        {
            int sumaTotal = userNumber.Sum();
            int maxxNumber = userNumber.Max();

            Console.WriteLine("--------result------");
            Console.WriteLine($"Suma Total: {sumaTotal}");
            Console.WriteLine($" Largest Number: {maxxNumber}");
        }
        else
        {
            Console.WriteLine("No valid numbers added");
        }
    }
}
