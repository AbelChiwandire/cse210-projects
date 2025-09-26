using System;
using System.Diagnostics.Contracts;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    List<Comment> comments;

    public Video(string title, string author, int lenghtInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lenghtInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            comment.Display();
        }
    }
}