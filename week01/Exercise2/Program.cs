using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the course with a grade of {letter}.");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass. You received a grade of {letter}. Try harder next time!");
        }
        char sign = ' '; 

        if (letter != "F") 
        {
            int lastDigit = gradePercentage % 10;

            if (lastDigit >= 7)
            {
                sign = '+';
            }
            else if (lastDigit <= 2)
            {
                sign = '-';
            }
        }
        if (sign != ' ')
        {
            Console.WriteLine($"Your final grade is {letter}{sign}.");
        }
        else
        {
            Console.WriteLine($"Your final grade is {letter}.");
        }
    }
}
