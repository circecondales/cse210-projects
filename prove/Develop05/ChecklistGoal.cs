using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoint;
    public ChecklistGoal(string name, string description, int points, int timesCompleted, int targetCount, int bonusPoint)
    : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoint = bonusPoint;
    }
    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _targetCount)
        {
            return _points + _bonusPoint; // Bonus awarded
        }
        return _points;
    }
    public override bool IsComplete()
    {
        if (_timesCompleted >= _targetCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetdetailString()
    {
        return base.GetdetailString() + " -- Currently completed: " + _timesCompleted + "/" + _targetCount;
    }
    public override string GetStringRepresentation()
    {
        return "ChecklistGoal: " + _name + "," + _description + "," + _points + "," + _bonusPoint + "," + _targetCount + "," + _timesCompleted;
    }

}