using System;
using System.IO;

class MindfulnessActivity
{
    public string ActivityName { get; set; }
    public int Duration { get; set; }
    public string ProgressFileName { get; set; }

    public MindfulnessActivity(string name, int duration)
    {
        ActivityName = name;
        Duration = duration;
        ProgressFileName = $"{ActivityName}_Progress.txt"; 
    }

    public void SaveProgress(string progressData)
    {
        try
        {
           
            File.WriteAllText(ProgressFileName, progressData);
            Console.WriteLine("Progress saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving progress: " + ex.Message);
        }
    }

    public string LoadProgress()
    {
        try
        {
            
            if (File.Exists(ProgressFileName))
            {
                
                return File.ReadAllText(ProgressFileName);
            }
            else
            {
                return null; 
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading progress: " + ex.Message);
            return null;
        }
    }
}
