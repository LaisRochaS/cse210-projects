using System.Collections.Generic;

public class Dictionary
{
    private Dictionary<string, string> _wordDefinitions;

    public Dictionary()
    {
        _wordDefinitions = new Dictionary<string, string>
        {
            { "atonement", "The reconciliation of God and mankind through Jesus Christ." },
            { "grace", "God's unmerited favor and love for humankind." },
            { "salvation", "The act of being saved from sin and its consequences." }
        };
    }

    // Get the definition of a word
    public string GetDefinition(string word)
    {
        return _wordDefinitions.ContainsKey(word) ? _wordDefinitions[word] : "Definition not available.";
    }
}
