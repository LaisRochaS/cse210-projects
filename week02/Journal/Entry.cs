using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    // New entry
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // Display entry
    public void DisplayEntry()
    {
        Console.WriteLine($"{Date} - Prompt: {Prompt}\nResponse: {Response}\n");
    }
}
