using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("John", 3, 16);

        // Define the scripture text
        string scriptureText = """For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.""";

       
        Scripture scripture = new Scripture(reference, scriptureText);

        
        Dictionary dictionary = new Dictionary();

        // Initialize the streak tracker
        StreakTracker streakTracker = new StreakTracker();

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine($"Today's scripture is: {reference.GetDisplayText()}");

       
        Console.WriteLine("\nHere are the definitions for some key words in this scripture:");
        Console.WriteLine($"Atonement: {dictionary.GetDefinition("atonement")}");
        Console.WriteLine($"Grace: {dictionary.GetDefinition("grace")}");
        Console.WriteLine($"Salvation: {dictionary.GetDefinition("salvation")}");

        
        scripture.DisplayWithHiddenWords();

        // Log practice and check streak
        streakTracker.LogPractice();
        streakTracker.CheckStreak();

        Console.WriteLine("\nThank you for practicing! Keep up the great work!");
    }
}
