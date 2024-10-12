using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to use C#", "Ivan Leffalle", "1800 seconds");
        Comment comment1 = new Comment("Vic", "This is a great video");
        Comment comment2 = new Comment("Ivan", "I like this video");
        Comment comment3 = new Comment("Gonza", "I love this video");
        Comment comment4 = new Comment("Linda", "Nice job");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);
        videos.Add(video1);




        Video video2 = new Video("How to use Python", "Joe Doe", "1200 seconds");
        Comment comment5 = new Comment("Jhon", "This is a great video");
        Comment comment6 = new Comment("Peter", "I like this video");
        Comment comment7 = new Comment("Mary", "I Love it");
        Comment comment8 = new Comment("Luke", "I Want more Videos");
        Comment comment9 = new Comment("Daniel", "good Job!");

        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);
        video2.AddComment(comment9);
        videos.Add(video2);

        foreach (Video video in videos)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine(video.GetDisplayComments());
            Console.WriteLine("***************************************");
        }
    }
}