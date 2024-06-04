using System;

public class Video 
{
    private string _title;

    private string _author;

    private double _videoLength;
    
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;

        _author = author;

        _videoLength = length;
    }
    public void DisplayVideoComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumberofComments()
    {
        int count = 0;

        count = _comments.Count;

        return count;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_videoLength} seconds");

        Console.WriteLine();

        int commentCount = NumberofComments();

        Console.WriteLine($"Number of comments: {commentCount}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }    
    }
}