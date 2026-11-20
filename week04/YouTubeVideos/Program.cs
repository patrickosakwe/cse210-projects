using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video(
            "Learning C# Programming",
            "Micheal Akpan",
            600);

        video1.AddComment(new Comment("David", "This tutorial is very helpful."));
        video1.AddComment(new Comment("Mary", "I learned a lot from this video."));
        video1.AddComment(new Comment("Peter", "Great explanation."));
        video1.AddComment(new Comment("Grace", "Please make more tutorials."));

        // Create the second video
        Video video2 = new Video(
            "Introduction to Python",
            "Patrick Osakwe",
            720);

        video2.AddComment(new Comment("James", "Python is interesting."));
        video2.AddComment(new Comment("Linda", "Very easy to understand."));
        video2.AddComment(new Comment("Michael", "Thank you for sharing."));
        video2.AddComment(new Comment("Esther", "I enjoyed this lesson."));

        // Create the third video
        Video video3 = new Video(
            "Web Development for Beginners",
            "Wale Adekoya",
            900);

        video3.AddComment(new Comment("Daniel", "Excellent introduction."));
        video3.AddComment(new Comment("Ruth", "I love web development."));
        video3.AddComment(new Comment("Samuel", "This helped me a lot."));
        video3.AddComment(new Comment("Joy", "Looking forward to more videos."));

        // Create the fourth video
        Video video4 = new Video(
            "Understanding Object-Oriented Programming",
            "David Oluwafemi",
            840);

        video4.AddComment(new Comment("Chris", "Abstraction is becoming clearer."));
        video4.AddComment(new Comment("Helen", "Very informative."));
        video4.AddComment(new Comment("Frank", "Great programming lesson."));
        video4.AddComment(new Comment("Rose", "I appreciate this explanation."));

        // Store all videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("==============================");
            video.Display();
            Console.WriteLine();
        }
    }
}