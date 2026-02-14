using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection.Metadata.Ecma335;
//coordinator: Esta clase divide el texto original en una lista de objetos Word
public class Scriptures
{
    private Reference _reference;
    private List<Word> _words;

    public Scriptures(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Dividimos el texto por espacios y creamos objetos Word
        string[] splitText = text.Split();
        foreach (string wordText in splitText) /*Crea una lista vacía de palabras
3️⃣ Divide el texto en palabras usando espacios*/
        {
            _words.Add(new Word(wordText)); //Convierte cada palabra en un objeto Word
        }
    }
    public void HideRandomWords(int numberToHide) //Sirve para ocultar palabras al azar.
    {
        Random random = new Random();

        // Get visible words (not hidden) Oculta cierta cantidad de palabras al azar sin repetirlas.
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        int toHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < toHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Avoid selecting the same word twice
        }
    }

    public string GetDisplayText()//Construye el texto para mostrar en pantalla.
    {   //Junta todas las palabras:
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()//Revisa si todas las palabras están ocultas.
    {
        return _words.All(word => word.IsHidden());
    }

}