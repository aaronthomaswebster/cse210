using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video coolVideo = new Video("My Cool Video", "Aaron Webster", 600);
        Video catVideo = new Video("Cat chases bird", "Thomas Jefferson", 45);
        Video cakeVideo = new Video("How to make a cake", "Chef Taylor", 820);

        coolVideo.AddComment(new Comment("This is a great video!","User1234"));
        coolVideo.AddComment(new Comment("I love this video!","User5678"));
        coolVideo.AddComment(new Comment("This is a great video!","User1234"));

        catVideo.AddComment(new Comment("Oh! That bird bearly made it.","catLover123"));
        catVideo.AddComment(new Comment("Cats are gross!","dogLover123"));
        catVideo.AddComment(new Comment("I love cats!","catLover123"));

        cakeVideo.AddComment(new Comment("I made this cake!","Chef Taylor"));
        cakeVideo.AddComment(new Comment("Why is this video so long?","User567"));
        cakeVideo.AddComment(new Comment("This looks deliscious","cakeMaker2"));

        videos.Add(coolVideo);
        videos.Add(catVideo);
        videos.Add(cakeVideo);
        
        foreach(Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine("Title: "+video.GetTitle());
            Console.WriteLine("Author: "+video.GetAuthor());
            Console.WriteLine("Length: "+video.GetLengthInSeconds());
            Console.WriteLine("Comments("+video.GetNumberOfComments()+"): ");
            foreach(Comment comment in video.GetComments())
            {
                comment.displayComment();
            }
        }

    }
}