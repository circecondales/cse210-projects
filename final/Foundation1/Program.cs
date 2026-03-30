using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store our videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C# in 10 Minutes", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "This was so helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "I finally understand classes now."));
        video1.AddComment(new Comment("Charlie", "Can you make a video about Lists?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 PC Builds 2024", "TechGuru", 1200);
        video2.AddComment(new Comment("Dave", "That GPU is massive!"));
        video2.AddComment(new Comment("Eve", "Great editing on this one."));
        video2.AddComment(new Comment("Frank", "What power supply did you use?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Best Pizza in Italy", "TravelVlog", 900);
        video3.AddComment(new Comment("Grace", "Now I'm hungry! Awesome video."));
        video3.AddComment(new Comment("Heidi", "The cinematography is beautiful."));
        video3.AddComment(new Comment("Ivan", "I need to visit that restaurant."));
        videos.Add(video3);

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._comenterName}: {comment._text}");
            }
        }
        Console.WriteLine("--------------------------------------------------");
    }
}