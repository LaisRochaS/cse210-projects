using System;

public class StreakTracker
{
    private DateTime? _lastPracticeDate;

    public void LogPractice()
    {
        _lastPracticeDate = DateTime.Now;
        Console.WriteLine("Practice logged! Keep up the good work.");
    }

    public void CheckStreak()
    {
        if (_lastPracticeDate.HasValue)
        {
            var daysSinceLastPractice = (DateTime.Now - _lastPracticeDate.Value).Days;
            if (daysSinceLastPractice == 1)
            {
                Console.WriteLine("You're on a 1-day streak! Keep going.");
            }
            else if (daysSinceLastPractice == 0)
            {
                Console.WriteLine("You’ve already practiced today. Great job!");
            }
            else
            {
                Console.WriteLine($"Your streak was broken after {daysSinceLastPractice} days.");
            }
        }
       
    }
}
