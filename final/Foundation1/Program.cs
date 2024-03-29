using System;
using System.Collections.Generic;

class Video
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string name, string author, int lengthInSeconds, List<Comment> comments)
    {
        Name = name;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = comments;
    }
}

class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}

class Program
{
    static void Main()
    {
        Video video1 = new Video("Birds Aren't Real", "Local Crackhead", 120, new List<Comment>
        {
            new Comment("FBI Official", "We can neither confirm nor deny the legitimacy of this video."),
            new Comment("Homeland Security", "Is this where the defense budget is going?"),
            new Comment("NotABird69", "If I could make a correction, we don't poop on cars to place trackers, we do it because we like to.")
        });

        Video video2 = new Video("Flying with the power of depression", "Backyard Scientist", 180, new List<Comment>
        {
            new Comment("Sadman", "Finally something I can use my sadness for."),
            new Comment("techie110", "Isn't advancement wonderful"),
            new Comment("GenericYoutuber1", "Didn't know this was a thing but good to know.")
        });

        Video video3 = new Video("How to purify Uranium", "NotATerrorist", 150, new List<Comment>
        {
            new Comment("Gandhi", "Please do not, war is never the option"),
            new Comment("Spambot100", "Congrats, you've won a prize! Message this account to claim it."),
            new Comment("NotATerrorist", "Why is the FBI here"),
            new Comment("FBI Official", "We just have to make sure you're not building a nuke in your garage")
        });

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Video Name: {video.Name}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}