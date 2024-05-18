using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> text = new List<string>();
        List<string> verse = new List<string>();
        text.Add("For God so loved the world...");
        text.Add("And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God.");
        text.Add("I say unto you that if ye should serve him who has created you from the beginning, and is preserving you from day to day, by lending you breath, that ye may live and move and do according to your own will");
        verse.Add("John 3:16-18");
        verse.Add("Mosiah 2:41");
        verse.Add("Mosiah 2:21");
        var random = new Random();
        int number = random.Next(verse.Count);
        int numb = random.Next(text.Count);
        // Create a scripture object with the reference and text
        Scripture scripture = new Scripture(verse[number], text[numb]);
        

        // Scripture scripture2 = new Scripture("Mosiah 2:41", "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.")   
        // Display the initial scripture
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to hide more words or type 'quit' to end.");

        // Loop until all words are hidden or user types 'quit'
        while (!scripture.IsCompletelyHidden() && Console.ReadLine() != "quit")
        {
            // Hide a few random words
            scripture.HideRandomWords(2); // Change the number of words to hide as desired
            
            // Clear the console
            Console.Clear();
            
            // Display the updated scripture
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide more words or type 'quit' to end.");
        }
    }
}