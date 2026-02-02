using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Método para mostrar la entrada en pantalla
    public void Display()
    {
        Console.WriteLine($"{_date}, {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}