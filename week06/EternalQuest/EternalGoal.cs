public class EternalGoal : Goal
{
    private int timesRecorded;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points) 
    {
        this.timesRecorded = 0;
    }

    public override void RecordEvent()
    {
        timesRecorded++;
        Console.WriteLine($"You recorded an event for the goal: {shortName}. Total recordings: {timesRecorded}");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals never complete
    }

    public override string GetStringRepresentation()
    {
        string progressBar = new string('#', timesRecorded) + new string('-', 10 - timesRecorded); // Simple progress bar
        return $"{shortName}: {description} - {points} points per record [{progressBar}]";
    }
}
