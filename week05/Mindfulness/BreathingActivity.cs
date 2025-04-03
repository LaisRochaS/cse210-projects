using System;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration)
        : base("Breathing", duration)
    {
    }

    public void StartBreathing()
    {
       
        Console.WriteLine("Do you want to load your previous session? (y/n)");
        if (Console.ReadLine().ToLower() == "y")
        {
          
            string savedProgress = LoadProgress();
            if (!string.IsNullOrEmpty(savedProgress))
            {
                Console.WriteLine("Resuming saved session...");
                Console.WriteLine(savedProgress);
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

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(2000); 
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(2000); 
        }

        // Save progress (empty for breathing activity as no user input is stored)
        SaveProgress("Breathing session completed.");
    }
}
