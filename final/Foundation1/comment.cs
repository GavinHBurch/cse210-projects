using System;

public class Comment
{
    private string _commentAuthor;
    private string _commentText;
    public Comment(string name, string text)
    {
        _commentAuthor = name;

        _commentText = text;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{_commentAuthor} - {_commentText}");
    }

    internal void DisplayVideoInfo()
    {
        throw new NotImplementedException();
    }
}