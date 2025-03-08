using System;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>(); 
        int inputNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = sum / (double)numbers.Count;
        int largestNumber = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }
        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort(); 
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
