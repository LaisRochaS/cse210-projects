public abstract class Goal
{
    protected string shortName;
    protected string description;
    protected int points;

    public int Points => points; // Property to return points

    public Goal(string name, string description, int points)
    {
        this.shortName = name;
        this.description = description;
        this.points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}
