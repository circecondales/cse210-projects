using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int _points) : base(name, description, _points){}

    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "EternalGoal:" + _name + "," + _description + "," + _points;
    }


}