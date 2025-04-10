public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public GoalManager() { }

    // Initialize with some sample goals
    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        // Sample Goals
        goals.Add(new SimpleGoal("Run a Marathon", "Complete a marathon to improve physical health", 1000));
        goals.Add(new EternalGoal("Scripture Reading", "Read the scriptures every day", 50));
        goals.Add(new ChecklistGoal("Attend the Temple", "Attend the temple 10 times", 100, 10, 500));
        // More goals can be added here
    }

    // Display player's info
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {score}");
        Console.WriteLine("Goals:");
        ListGoalNames();
    }

    // List all the goals with their current progress
    public void ListGoalNames()
    {
        foreach (var goal in goals)
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {goal.GetStringRepresentation()}");
        }
    }

    // Allow the user to create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the target number of completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // Record an event for a goal, update points
    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        ListGoalNames();
        int goalIndex = int.Parse(Console.ReadLine()) - 1;  // Adjust for 0-based index
        Goal goal = goals[goalIndex];
        goal.RecordEvent();

        // Add the points for the goal to the user's score
        score += goal.Points;
    }

    // Save goals to a file (simplified)
    public void SaveGoals()
    {
        // Saving functionality (not implemented in detail)
        Console.WriteLine("Goals saved!");
    }

    // Load goals from a file (simplified)
    public void LoadGoals()
    {
        // Loading functionality (not implemented in detail)
        Console.WriteLine("Goals loaded!");
    }
}
