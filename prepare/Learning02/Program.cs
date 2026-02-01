using System;

class Program
{
    static void Main(string[] args)
    {
       //onsole.WriteLine("Hello Learning02 World!");

// Crear una nueva instancia de la clase Job llamada job1
        Job Job1 = new Job();

        Job1._jobTitle = "Software Engineer";
        Job1._companyName = "Microsoft";
        Job1._startYear = "2019";
        Job1._endYear = "2022";

        Job Job2 = new Job();

        Job2._jobTitle = "Manager";
        Job2._companyName = "Apple";
        Job2._startYear = "2022";
        Job2._endYear = "2023";

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        //add a call at the end to the Display method from your Resume class
        // to display the name and all the jobs in one line.
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

        myResume.Display();
    }
}