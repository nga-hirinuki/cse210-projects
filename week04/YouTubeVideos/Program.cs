using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the videos.
        List<Video> videos = new List<Video>();

        // Create the first video and add some comments.
        Video video1 = new Video("Learning C# Basics", "JohnDoe", 300);
        video1.Comments.Add(new Comment("Alice", "Great tutorial!"));
        video1.Comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        video1.Comments.Add(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        // Create the second video and add some comments.
        Video video2 = new Video("Advanced C# Techniques", "JaneSmith", 600);
        video2.Comments.Add(new Comment("Dave", "Challenging but worth it."));
        video2.Comments.Add(new Comment("Eve", "I love advanced topics."));
        video2.Comments.Add(new Comment("Frank", "Can you do one on LINQ next?"));
        videos.Add(video2);

        // Create the third video and add some comments.
        Video video3 = new Video("C# for Beginners", "CodeMaster", 450);
        video3.Comments.Add(new Comment("Grace", "Perfect for beginners!"));
        video3.Comments.Add(new Comment("Heidi", "Thanks for breaking it down."));
        video3.Comments.Add(new Comment("Ivan", "I wish I found this earlier."));
        videos.Add(video3);

        // Iterate through each video and display its details.
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("   " + comment.Commenter + " said: " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}
