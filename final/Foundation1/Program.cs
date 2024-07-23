using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        int count = 0;
        
        Video video = new Video("Top 10 most beatiful animals in the World", "World Reviewer", "120");
        
        Comment comment11 = new Comment("Miwa12", "Nice Video");
        Comment comment12 = new Comment("AikoGamePlays", "I love the 5 place");
        Comment comment13 = new Comment("JoshitoCrepper", "Blue Dragon Sea should being in the Top! ");

        video.AddComment(comment11);
        video.AddComment(comment12);
        video.AddComment(comment13);

        Video video1 = new Video("Orange Juice or Water for breakfast? ", "Healthy Life", "240");
        
        Comment comment21 = new Comment("Hater1", "Well, I still drink Orange Juice for breakfast anyways.");
        Comment comment22 = new Comment("MohitoCrazy", "That's why I just drink vine in the mornings!");
        Comment comment23 = new Comment("HelamanSUD", "Nice video!");

        video1.AddComment(comment21);
        video1.AddComment(comment22);
        video1.AddComment(comment23);

        
        Video video2 = new Video("The mist - by Stephen King - Movie Review", "Markiplayer", "487");

        Comment comment31 = new Comment("Brother Burton", "I hate the end");
        Comment comment32 = new Comment("StephenKingLover", "This is the best book adaptation of a Stpehen King's Book");
        Comment comment33 = new Comment("Hater2", "Nah, Nothing Bad");

        video2.AddComment(comment31);
        video2.AddComment(comment32);
        video2.AddComment(comment33);

        
        Video video3 = new Video("Mountain Vlog", "ZicoTops", "650");

        Comment comment41 = new Comment("MichaelMyers", "First Comment");
        Comment comment42 = new Comment("TheWalkMan", "I have been on that Mountian several times, I love how the sky is when night is comming!");
        Comment comment43 = new Comment("Aldoxito", "La naturaleza es tan hermosa, igual de hermosa que soy yo");
        Comment comment44 = new Comment("Luluking", "Awsome!");

        video3.AddComment(comment41);
        video3.AddComment(comment42);
        video3.AddComment(comment43);
        video3.AddComment(comment44);

        _videos.Add(video);
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        Console.WriteLine("---------------------------------------------- COMMENTS CONTROL CENTER ----------------------------------------------");
        Console.WriteLine("");


        foreach (Video v in _videos)
        {
            count += 1;

            Console. WriteLine("");            
            Console.Write(count + ". ");
            v.DisplayVideos();
            Console.WriteLine("");
            v.DisplayComment();
        }
    }
}