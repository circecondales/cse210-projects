// Definición de la clase Job
public class Job
{
    public string _jobTitle;
    public string _companyName;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} {_endYear}");
    }
    // Definición de la clase Resume

}
public class Resume
{
    public string _name;
    // Es vital inicializar la lista aquí para evitar errores
    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"Resume {_name} {_jobs}");
        Console.WriteLine("jobs:");
        foreach (Job job in _jobs)
        {
            // Iterar sobre cada trabajo en la lista y llamar a su propio método Display
            job.Display();
        }
    }
 }
