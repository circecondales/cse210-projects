using System.Collections.Generic;
public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

   // Constructor que llama al constructor de la clase base
    public MathAssignment(string textBookSection, string studentName, string problems, string topic)
        : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;

    }
    public string GetHomeworkList()
    {
        return $"Name of the book: {_textBookSection}, Topic: {_problems}";
    }
    // Clase derivada MathAssignment que hereda de Assignment

}