using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("Alma 39-41", "Alma Teachs Corianton about Resurrection and Judment",1200 );
        
        video1.AddComment(new Comment("Anonymous", "The is no resurrection until after the coming of Christ."));
        video1.AddComment(new Comment("Anonymous", "There is a space between the time of death and resurrection."));
        video1.AddComment(new Comment("Anonymous", "Wickedness never was happiness."));
        
        videos.Add(video1);
        
        Video video2 = new Video("Corinthians 12", "Resurrection of the Death | The Bible", 800);
        
        video2.AddComment(new Comment("Adam", "All die even so in Christ shall all be made alive."));
        video2.AddComment(new Comment("21", "And the eye cannot say unto the hand, I have no need of thee: nor again the head to the feet, I have no need of you."));
        video2.AddComment(new Comment("26",  "And whether one member suffer, all the members suffer with it; or one member be honoured, all the members rejoice with it."));
        
        videos.Add(video2);
        
        Video video3 = new Video("Elder Quentin L.", "Choosing Eternal Families Over Modern-Day 'Idols'.", 900);
        
        video3.AddComment(new Comment("Elder Quentin L.", "Let's not make them an Idol."));
        video3.AddComment(new Comment("Elder Quentin L.", "Don't create Idols."));
        video3.AddComment(new Comment("Elder Quentin L.","Keep your goals on eternal families. "));
        
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            Console.WriteLine("");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
        

        foreach (Comment comment in video.GetComments())
        {
            Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
        }
            
        }
    }
}