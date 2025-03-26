using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        Video video1 = new Video("Learning C# Basics", "John Doe", 300);
        video1.Comments.Add(new Comment("Alice", "Great video, thanks for the tips!"));
        video1.Comments.Add(new Comment("Bob", "I learned a lot from this, appreciate it."));
        video1.Comments.Add(new Comment("Charlie", "This is exactly what I needed, thanks!"));

        // Liking and disliking
        video1.Like();
        video1.Like();
        video1.Dislike();
        
        // Liking and disliking comments
        video1.Comments[0].Like();
        video1.Comments[1].Dislike();
        video1.Comments[2].Like();

        
        Video video2 = new Video("Advanced C# Programming", "Jane Smith", 600);
        video2.Comments.Add(new Comment("David", "Very informative, but can you go over some more examples?"));
        video2.Comments.Add(new Comment("Emily", "I’ve been struggling with this topic, this helped!"));
        video2.Comments.Add(new Comment("Frank", "Clear explanation, keep up the good work!"));

        // Liking and disliking
        video2.Like();
        video2.Dislike();
        
        // Liking and disliking comments
        video2.Comments[0].Like();
        video2.Comments[1].Dislike();
        video2.Comments[2].Like();

      
        Video video3 = new Video("Mastering C# Lambda Expressions", "Sarah Lee", 450);
        video3.Comments.Add(new Comment("Tom", "Lambda expressions are confusing, can you explain more?"));
        video3.Comments.Add(new Comment("Anna", "This tutorial was exactly what I needed!"));
        video3.Comments.Add(new Comment("Zoe", "Could you go over more practical examples of lambdas?"));

        // Liking and disliking
        video3.Like();
        video3.Dislike();
        
        // Liking and disliking comments
        video3.Comments[0].Dislike();
        video3.Comments[1].Like();
        video3.Comments[2].Dislike();

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
