using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    // Hide a random word
    public void HideRandomWord()
    {
        int index = _random.Next(_words.Count);
        _words[index].Hide();
    }

    
    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    
    public void DisplayWithHiddenWords()
    {
        while (!IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine($"Scripture: {Reference.GetDisplayText()}");
            Console.WriteLine(GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            HideRandomWord();
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Great job!");
    }
}
