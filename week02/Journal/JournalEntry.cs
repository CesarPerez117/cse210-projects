using System;

public class JournalEntry // JournalEntry class can be use it every time an user is writting a new journal entry.
{
    public string _dateTime = ""; // takes the time and date where the user entered the info.
    public string _promptText = ""; // takes the prompt or question the user will answer. 
    public string _entryText = ""; // takes what the user answered

    public JournalEntry()
    {
        
    }

    public void Display() // organize the data and display it
    {
        Console.WriteLine($"Date: {_dateTime} - {_promptText}");
        Console.WriteLine($"> {_entryText}");
    }
}