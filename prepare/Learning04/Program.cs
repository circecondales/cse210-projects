using System;

class Program
{
    static void Main(string[] args)
    {   // Crear una instancia de MathAssignment
        MathAssignment mathAssignment= new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        // Mostrar el resumen y la lista de tareas, mathasigment llama a getsummary y gethomework
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // Crear una instancia de WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}