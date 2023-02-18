using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        

        // 1. Store a scripture, including both the reference (for example "John 3:16") 
        // and the text of the scripture.
        //Dictionary<string, string> Reference = new Dictionary<string, string>();

        //Reference.Add("John","John 3:16");
        //Reference.Add("3:16","For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        //Reference.Add("Proverbs", "Proverbs 3:5-6");
        //Reference.Add("3:5", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        //Reference.Add("3:6", "In all thy ways acknowledge him, and he shall direct thy paths.");
        // I will need to place variables to hold the scriptures. Then, I will try to create a
        // separated class to storage the scriptures. 

        // singleReference will display the reference: John 3:16
        //string singleReference = Reference["John"];
        // singleText will display the text: For God so bloved the world, that he gave his only 
        // begotten Son, that whosoever believeth in him should not perish, but have everlasting life.
        //string singleText = Reference["3:16"];
        

        int choice = 0;
        do 
        {
            Console.WriteLine("Scripture Memorizer");
            Console.WriteLine("1. Memorize Single Vers" + "\n2. Memorize Multiple Vers" + "\n3. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Display single scripture and work with the hideWords
                    Console.WriteLine();
                    break;
                case 2:
                    // Display multi scripture and work with the hideWords
                    break;
            }
        } while (choice != 3);

    }

    
}