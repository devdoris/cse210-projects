using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "Learning C# Basics",
            Author = "Code Academy",
            Length = 600
        };

        video1.AddComment(new Comment("Alice", "Very helpful video!"));
        video1.AddComment(new Comment("Bob", "Clear explanation."));
        video1.AddComment(new Comment("Chris", "Loved this tutorial."));

        Video video2 = new Video
        {
            Title = "OOP Explained",
            Author = "Tech World",
            Length = 720
        };

        video2.AddComment(new Comment("Doris", "This finally makes sense."));
        video2.AddComment(new Comment("Eve", "Great examples."));
        video2.AddComment(new Comment("Frank", "Well explained!"));

        Video video3 = new Video
        {
            Title = "Abstraction in C#",
            Author = "Programming Hub",
            Length = 540
        };

        video3.AddComment(new Comment("Grace", "Exactly what I needed."));
        video3.AddComment(new Comment("Henry", "Nice and simple."));
        video3.AddComment(new Comment("Ivy", "Thanks for this!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
