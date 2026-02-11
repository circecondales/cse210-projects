using System;
using System.Collections.Generic;

using System.Linq;
//coordinator: Esta clase divide el texto original en una lista de objetos Word
public class Scriptures
{
    private Reference _reference;
    private List<Word> _words;

    public Scriptures(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
    }
}