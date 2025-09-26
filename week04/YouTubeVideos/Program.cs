using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // list to store all video objects
        List<Video> videos = new List<Video>();

        // Video 1 object
        Video video1 = new Video("Love yours", "J cole", 212);
        Comment comment1 = new Comment("Kendrick", "Cole the goat");
        Comment comment2 = new Comment("Pusha T", "What's money without happiness, or hard times without the people you love?");
        Comment comment3 = new Comment("DJ Khaled", "No such thing!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        // Add video 1 object to list
        videos.Add(video1);

        // Video 2 object
        Video video2 = new Video("OMG", "Ace Hood", 134);
        Comment comment4 = new Comment("Wale", "Felt it in my bones");
        Comment comment5 = new Comment("Chris", "The beat goes hard!");
        Comment comment6 = new Comment("Mr Hood", "Goat");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        // Add video 2 object to list
        videos.Add(video2);

        // Video 3 object
        Video video3 = new Video("Clouds", "J Cole", 230);
        Comment comment7 = new Comment("JID", "Dreamville, let's gooo!");
        Comment comment8 = new Comment("Bas", "Lyrical genius");
        Comment comment9 = new Comment("Abel", "Best to ever do it!");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        // Add video 3 object to list
        videos.Add(video3);

        // Display all video objects
        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine();
        }              
    }
}