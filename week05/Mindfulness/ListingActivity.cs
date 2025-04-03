using System;

class ListingActivity : MindfulnessActivity
{
    private string listedItems;

    public ListingActivity(int duration)
        : base("Listing", duration)
    {
    }

    public void StartListing()
    {
        Console.WriteLine("Please list as many items as you can. Type 'done' when finished.");
        listedItems = "";

        string item;
        while ((item = Console.ReadLine()) != "done")
        {
            listedItems += item + "\n";
        }

        // Save the listed items to file
        SaveProgress(listedItems);
    }
}
