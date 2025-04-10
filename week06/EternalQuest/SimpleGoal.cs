public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        this.isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            Console.WriteLine($"You completed the goal: {shortName} and earned {points} points!");
        }
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetStringRepresentation()
    {
        string status = isComplete ? "[X] Completed" : "[ ] Not Completed";
        return $"{shortName}: {description} - {points} points {status}";
    }
}
