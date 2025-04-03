using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("1. Reflection Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Breathing Activity");

        // Get user choice
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // Start Reflection Activity
            ReflectionActivity reflection = new ReflectionActivity(10); 
            reflection.StartReflection();
        }
        else if (choice == 2)
        {
            // Start Listing Activity
            ListingActivity listing = new ListingActivity(10); 
            listing.StartListing();
        }
        else if (choice == 3)
        {
            // Start Breathing Activity
            BreathingActivity breathing = new BreathingActivity(10); 
            breathing.StartBreathing();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
