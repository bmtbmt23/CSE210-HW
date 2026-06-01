using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<comment> _comments;
   
    public video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<comment>();
    }
    public string GetAuthor()
    {
        return _author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public int GetLenghthInSeconds()
    {
        return _lengthInSeconds;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(_comments);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
   
    public string GetDisplayInfo()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLenght: {_lengthInSeconds}\nComments: {GetCommentCount()}";
    }
}