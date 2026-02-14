using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection.Metadata.Ecma335;
//coordinator: Esta clase divide el texto original en una lista de objetos Word
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor para un solo versículo (ej. Juan 3:16)
    public Reference(string book, int chapter, int verse)
    {
        _book = book; //"juan"
        _chapter = chapter; //3
        _verse = verse; //16
        _endVerse = verse; // tambien 16 -end is the same at the begining = Si solo es un versículo, el inicio y el final son iguales.
    }
    public string GetDisplayText() //Este método devuelve el texto listo para mostrarse
    {
        if (_verse == _endVerse) //Si el versículo inicial y final son iguales:
        {
            return $"{_book} {_chapter}: {_verse}";
        }
        return $"{_book} {_chapter}:{_verse} {_endVerse}";
    }


}