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
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // end is the same at the begining
    }
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}: {_verse}";
        }
        return $"{_book} {_chapter}:{_verse} {_endVerse}";
    }


}