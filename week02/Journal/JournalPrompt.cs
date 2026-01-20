using System;

public class JournalPrompt
{
    string[] _journalPrompts =
    {
        "What was the best part of my day? ",
        "Who was the most interesting preson I interacted with today? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? "
    };

    public string GetRandomPrompt()
    {
        Random rndPrompt = new Random();
        int randomPromptInt = rndPrompt.Next(_journalPrompts.Length); 
        // Next retrieves a number and becuse I am asking for lenght, it will
        // retrieve any number from 0 to 4.
        string randomPrompt = (_journalPrompts[randomPromptInt]);
        // Now I am using the number I got to select it from the list and return
        return randomPrompt;

    }
}