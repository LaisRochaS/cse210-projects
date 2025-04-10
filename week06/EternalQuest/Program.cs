class Program
{  
      static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start(); // Initializes some sample goals or starts a session

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== Eternal Quest Menu ===");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.DisplayPlayerInfo();
                    break;
                case "2":
                    manager.ListGoalNames();
                    break;
                case "3":
                    manager.CreateGoal();
                    break;
                case "4":
                    manager.RecordEvent();
                    break;
                case "5":
                    manager.SaveGoals();
                    break;
                case "6":
                    manager.LoadGoals();
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Thanks for playing Eternal Quest!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
