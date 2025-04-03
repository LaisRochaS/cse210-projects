using System;
using System.IO;

public static class Helper
{
    public static void SaveToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    public static string ReadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            return File.ReadAllText(filename);
        }
        return null;
    }
}
