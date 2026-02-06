using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction v1 = new Fraction();
        Console.WriteLine("Fraction 1 (default)");
        v1.Display();

        // 2. Usando el segundo constructor (un parámetro) para 6/1
        Fraction v2 = new Fraction(6);
        Console.WriteLine("Fraction 2 (whole number) ");
        v2.Display();

        // 3. Usando el tercero constructor (dos parámetros) para 6/7
        Fraction v3 = new Fraction(6, 7);
        Console.WriteLine("Fraction 3 (fraction)");
        v3.Display();
    }
}