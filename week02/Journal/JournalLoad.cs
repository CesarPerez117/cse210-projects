using System;

public class JournalLoad // the origin of this is explained in case #3, Program.cs
{
    public string _loadedText = "";
    public JournalLoad()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_loadedText}");
    }

}