using System;

public class JournalEntry
{
    // I will need to create a function that will take the 
    // information from the JournalPrompts and show it to 
    // the user.

    // To get and display the information, I will use the example in 
    // Week 03, Abstraction Learning Activity Overview

    // The C# convention is to start member variables with an underscore _
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalAnswer = "";

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public JournalEntry()
    {
    }

    // A method that displays the person's full Journal Entry
    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime} - Prompt: {_journalPrompt}");
        Console.WriteLine($"> {_journalAnswer}");
    }
}