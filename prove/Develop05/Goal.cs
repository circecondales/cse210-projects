using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    // This method returns the points earned when a goal is recorded
    public abstract int RecordEvent();

    // Tells us if the goal is finished
    public abstract bool IsComplete();

    // Returns a string for the list display
    public abstract string GetdetailString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return status + " " + _name + " (" + _description + ")";
    }
    public abstract string GetStringRepresentation();
}