using System;

class Program
{
    static void Main(string[] args)
    {
        //(string title, string author, double length)
        Video video1 = new Video("How to cook eggs","nqrse", 2.13);
        Video video2 = new Video("Javascript Course", "Brocode", 123.23);
        Video video3 = new Video("Game of Whimsy", "Gigi Murin", 230.23);

        //(string name,string text)
        video1.addComment(new Comment("Jake","Great tutorial!"));
        video1.addComment(new Comment("Daisy","Could you do a video on bread next?"));
        video1.addComment(new Comment("Marceil","A Quick breakfast."));

        video2.addComment(new Comment("Kevin","Good refresher course"));
        video2.addComment(new Comment("Kairav","I need an explaination on Python.."));
        video2.addComment(new Comment("Louie","This helped me with my project! thanks!"));

        video3.addComment(new Comment("Nerissa","Amazing Game!"));
        video3.addComment(new Comment("Iris","A casual game for the whole family."));
        video3.addComment(new Comment("Mumei","The intro made me laugh."));


        List<Video> videoList = new List<Video> { video1, video2, video3 };

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.GetDisplayVideo());

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine(c.getDisplayText());
                Console.WriteLine();
            }
        }
    }
}