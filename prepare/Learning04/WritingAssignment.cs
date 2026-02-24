using System.Collections.Generic;
public class WritingAssignment : Assignment
{
    private string _title;

   // Constructor que llama al constructor de la clase base
    public WritingAssignment(string studentName, string title, string topic)
        : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"Name of the study: {_title}";
    }
    // Clase derivada MathAssignment que hereda de Assignment

}