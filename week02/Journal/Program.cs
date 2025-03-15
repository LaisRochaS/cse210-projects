using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            
            Console.Clear();
            Console.WriteLine("Journal App");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. View journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    Random random = new Random();
                    int promptIndex = random.Next(prompts.Length);
                    string prompt = prompts[promptIndex];

                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    journal.AddEntry(new Entry(prompt, response, date));
                    Console.WriteLine("Entry added!");
                    break;

                case "2":
                    // View journal entries
                    journal.DisplayEntries();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "3":
                    // Save journal to a file
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved!");
                    break;

                case "4":
                    // Load journal from a file
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded!");
                    break;

                case "5":
                    // Exit the app
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
