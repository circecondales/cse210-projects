using System;

class Fraction
{
    private int _bottom;
    private int _top;
    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }
    public Fraction(int wholeNumber)
    {
        _bottom = 1;
        _top = wholeNumber;
    }
    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }
    // Método para mostrar la fracción (ayuda a verificar los constructores)
    public void Display()
    {
        Console.WriteLine($"{_bottom}, {_top}");
    }
    public GetFractionString int GetTop()
}