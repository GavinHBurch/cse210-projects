using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Miracles, Angels, and Preisthood Power", "Shayne M. Bowen", 704);

        Comment video1Comment1 = new Comment("Andrew", "The day of miracles has indeed not passed and in fact shall increase in frequency as we approach the second coming of Christ. I myself have seen miracles and been preserved by the hand of God.");

        Comment video1Comment2 = new Comment("Bryan", "Wow, this is the most powerful talk on the priesthood I've ever heard. I believe what he said. I know the priesthood has been restored.");

        Comment video1Comment3 = new Comment("user", "I miss my father, he passed in March 2024. He always gave me blessings.");

        video1.DisplayVideoComments(video1Comment1);

        video1.DisplayVideoComments(video1Comment2);

        video1.DisplayVideoComments(video1Comment3);

        videoList.Add(video1);

        Video video2 = new Video("In support of the Rising Generation", "Michael T. Nelson", 681);

        Comment video2Comment1 = new Comment("Nathan", "If we choose to love Jesus Christ above all other things, we can be free from the miserable grip of addiction, as well as a great hope that we can live with our loved ones with God forever!");

        Comment video2Comment2 = new Comment("Nova", "Lovely Talk and I really appreciate this talk. ");

        Comment video2Comment3 = new Comment("Mater", "Thank you.");

        video2.DisplayVideoComments(video2Comment1);

        video2.DisplayVideoComments(video2Comment2);

        video2.DisplayVideoComments(video2Comment3);

        videoList.Add(video2);

        Video video3 = new Video("Motions of a Hidden Fire", "Jeffrey R. Holland", 808);

        Comment video3Comment1 = new Comment("Nick", "I am not an LDS member.  I was figurately introduced to him from an active member, thru these General Conference presentations.  I am respectfully impressed by Elder Holland's human ness.  When he speaks, it is clear that he is a vessel of our Lord, giving us His hope. Elder Holland's testimony gives me hope.");

        Comment video3Comment2 = new Comment("Omar", "I am a less active member lost in the midst of darkness and listening to him propels me took seek the Lord and his Infinite mercy.");

        Comment video3Comment3 = new Comment("Steel", "President Holland's iron will and testimony are incredible.  On the verge of death multiple times, his wife is now passed beyond the veil; yet, he stays the course as a apostle of our Lord Jesus Christ.");

        video3.DisplayVideoComments(video3Comment1);

        video3.DisplayVideoComments(video3Comment2);

        video3.DisplayVideoComments(video3Comment3);

        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo();

            Console.WriteLine();

            Console.WriteLine();
        }
    }
}