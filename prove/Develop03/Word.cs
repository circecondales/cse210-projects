using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection.Metadata.Ecma335;
//coordinator: Esta clase divide el texto original en una lista de objetos Word
public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;// Por defecto, las palabras comienzan visibles
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Crea una cadena de guiones bajos de la misma longitud que la palabra
            return new string('_', _text.Length);
        }
        return _text;
    }
}