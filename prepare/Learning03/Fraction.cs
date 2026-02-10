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
    public string GetFractionString() // Devuelve la fracción como una cadena: "3/4"
    {
        return $"{_bottom}/{_top}";
    }
    public double GetDecimalValue() // Devuelve el valor decimal: 0.75
    {
        return _bottom / _top; // Forzamos que la operación use doubles para obtener decimales
    }
}