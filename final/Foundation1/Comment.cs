using System;

public class Comment{
    private string _author;
    private string _comment;

    public Comment(string comment, string commentorName)
    {
        _author = commentorName;
        _comment = comment;
    }

    public void displayComment()
    {
        Console.WriteLine(_comment + " - "+_author);
    }
}