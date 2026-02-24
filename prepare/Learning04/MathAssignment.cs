public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

   // Constructor que llama al constructor de la clase base
   public MathAssignment(string _textBookSection, string)
    {
        

    }
    public string GetSummary()
    {
        return $"Name: {_studentName}, Topic: {_topic}";
    }
    // Clase derivada MathAssignment que hereda de Assignment

}