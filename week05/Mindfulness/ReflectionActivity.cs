using System;

class ReflectionActivity : MindfulnessActivity
{
    private string reflectionResponse;

    public ReflectionActivity(int duration)
        : base("Reflection", duration)
    {
    }

    public void StartReflection()
    {
        
        Console.WriteLine("Do you want to load your previous session? (y/n)");
        if (Console.ReadLine().ToLower() == "y")
        {
            
            string savedProgress = LoadProgress();
            if (!string.IsNullOrEmpty(savedProgress))
            {
                Console.WriteLine("Resuming saved session...");
                Console.WriteLine(savedProgress);
                Console.WriteLine("You can continue reflecting...");
            }
            else
            {
                Console.WriteLine("No saved session found. Starting a new session...");
            }
        }
        else
        {
            Console.WriteLine("Starting a new session...");
        }

        Console.WriteLine("Please think of a meaningful experience. Type 'quit' when you are done.");
        reflectionResponse = "";

        
        string response;
        while ((response = Console.ReadLine()) != "quit")
        {
            reflectionResponse += response + "\n";
        }

        // Save the responses
        SaveProgress(reflectionResponse);
    }
}
