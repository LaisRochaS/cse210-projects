public class ChecklistGoal : Goal
{
    private int amountComplete;
    private int target;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        this.amountComplete = 0;
        this.target = target;
        this.bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (amountComplete < target)
        {
            amountComplete++;
            Console.WriteLine($"You completed a step for the goal: {shortName}. {amountComplete}/{target} completed.");
            Console.WriteLine($"You earned {points} points!");

            if (amountComplete == target)
            {
                Console.WriteLine($"Congratulations! You completed the goal and earned a bonus of {bonus} points!");
            }
        }
    }

    public override bool IsComplete()
    {
        return amountComplete >= target;
    }

    public override string GetStringRepresentation()
    {
        string progressBar = new string('#', amountComplete) + new string('-', target - amountComplete); // Simple progress bar
        return $"{shortName}: {description} - {amountComplete}/{target} completed. Bonus: {bonus} points [{progressBar}]";
    }
}
