using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("BYU Idaho Campus Tour", "BeSmartCES", 149); //real video
        video1.AddComment("Arunas Rancevas", "Great tour. I study here, but online so I never saw the campus.");//self insert
        video1.AddComment("Alchemist", "Great campus. I study chemistry here!");
        video1.AddComment("PhysicsFan", "My dream university!");
        video1.AddComment("ProgrammingTutorials", "Great university. I got my bachelors from here.");

        Video video2 = new Video("Top 10 most cool Kendo techniques", "KendoSinsai", 180);
        video2.AddComment("Arunas Rancevas", "Cool video!");
        video2.AddComment("KendoFan", "Great video!");
        video1.AddComment("FencingFan", "Boring video about boring sport.");
        video1.AddComment("SportFan", "Awesome video. Good job.");

        Video video3 = new Video("Top 10 most cool Fencing techniques", "FencingMaster", 180);
        video3.AddComment("Arunas Rancevas", "Cool video!");
        video3.AddComment("KendoFan", "Boring video about ungracefull sport.");
        video1.AddComment("FencingFan", "Great video!");
        video1.AddComment("SportFan", "Awesome video. Good job.");

        Video video4 = new Video("C# Tutorial", "ProgrammingTutorials", 1200);
        video4.AddComment("Arunas Rancevas", "Great tutorial!");
        video4.AddComment("C# fan", "Best video ever!!!");
        video4.AddComment("Javamaster", "Bad tutorial for bad language.");
        video4.AddComment("Programmingfan", "Interesting video. C# appears to be more similar to Java than C++. How odd.");
 
        List<Video> videos = new List<Video> {video1, video2, video3, video4};

 foreach (Video video in videos)
                {
                    Console.WriteLine($"{video.GetTitle()} " +
                        $"({video.GetLength()} s) by {video.GetAuthor()}");

                    foreach (Comment comment in video.GetComments())
                    {
                        Console.WriteLine($"    {comment.GetName()}: {comment.GetText()}");
                    }

        }
    }
} 