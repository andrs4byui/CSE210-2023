using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("perfect", "Ed Sheran", 180);
        video1._comments.Add(new Comment("Andres Soruco", "This song is the best"));
        video1._comments.Add(new Comment("Nazir Reynoso", "I like this Song"));
        video1._comments.Add(new Comment("Alcira Mamani", "Yeah, this song is the best"));
        
        Video video2 = new Video("Melancolicos Anonimos", "Sebastian Yatra", 160);
        video2._comments.Add(new Comment("Andres Soruco", "What a sad song"));
        video2._comments.Add(new Comment("Nazir Reynoso", "I like this Song"));
        video2._comments.Add(new Comment("Alcira Mamani", "I never listen this song before"));

        Video video3 = new Video("SinMigo", "Jose Madero", 125);
        video3._comments.Add(new Comment("Andres Soruco", "This is an old song"));
        video3._comments.Add(new Comment("Nazir Reynoso", "Is weird for me"));
        video3._comments.Add(new Comment("Alcira Mamani", "I know the artist but the song"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        for (int i = 0; i < videos.Count(); i++){
            videos[i].DisplayInformation();
            Console.WriteLine();
        }

    }
}