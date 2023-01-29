using System;
using System.IO; // Call it to use the writer in files.

// My team pers told me that if I storage the user entry in a list in another class
// I will be able to display it for 2nd option. 

// Also, they told me to better put here the save and load functions, so I will no
// broke my head trying to call the separate class. 
public class StorageJournal
{
    public List<JournalEntry> _storageJournal = new List<JournalEntry>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public StorageJournal()
    {
    }
    
    public void Display() // to display current journal in case 2
    {

        foreach (JournalEntry journalEntry in _storageJournal)
        {
            journalEntry.Display();
        }    
    }   


    // Let's go and create the LoadFile()
    // I believe I will check if file exists and get it load, 
    // if not, I will just prompt a message that wasn't found. 
    public void LoadFile()
    {
        // ask the file name
        Console.Write("What is the file name? ");
        string _userAnswer = Console.ReadLine();
        // Now use if to check if the file exists, if not, tell to user. 
        if (File.Exists(_userAnswer))
        { 
            string readText = File.ReadAllText(_userAnswer);
            Console.WriteLine($"File loaded. Ready to display.");
            // Console.WriteLine(readText);
            //_storageJournal.Add(readText);

        }
        else
        {
            Console.WriteLine("File does not exists.");
        }
    }

    // Now time to save the journal in a .txt file for case 4
    // VS said that I need to declase a public method
    public void SaveFile(string _fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // here, I am supose to write what I have and store it. 
            // so, I will just copy the display from JournalEntry().

            // It's giving me error, so I believe I need to call a foreach as the display
            foreach (JournalEntry journalEntry in _storageJournal)
            {
                outputFile.WriteLine($"Date: {journalEntry._dateTime} - Prompt: {journalEntry._journalPrompt}");
                outputFile.WriteLine($"> {journalEntry._journalAnswer}\n");
            }
        }
    }
    
    public void AddJournalToFile(string _fileName)
    { // Why I did another method? Because code was crashing up saying that I was using 
        // same code twice at same time so, now with this the code allow me to save the file :)
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (JournalEntry journalEntry in _storageJournal)
                {
                    outputFile.WriteLine($"Date: {journalEntry._dateTime} - Prompt: {journalEntry._journalPrompt}");
                    outputFile.WriteLine($"> {journalEntry._journalAnswer}\n");
                }
        }
    }


    // I need to create the file and ask for the name of the file. I tried in SaveFile()
    // but is not possible, I will need to use SaveFile as a method (function) only. 
    public void CreateFile() // here I will create the file and ask for the name,
                            // Also I need to check if the file exists or not T_T 
    {
        // ask the file name
        Console.WriteLine("What is the file name? ");
        // get the answer and store it
        string _userAnswer = Console.ReadLine();
        // Now use if to check if the file exists, if not, I need to create one. 
        if (!File.Exists(_userAnswer))
        {
            // Here, I will create a new file and add the journal.
            File.CreateText(_userAnswer);
            Console.Write("File Created.");
            Console.WriteLine($" Journal entry added to {_userAnswer} and saved.");
            SaveFile(_userAnswer);
        }
        else
        { 
            // I need to add the current journal if the file exists
            Console.WriteLine($"{_userAnswer} file exists. Journal added.");
            AddJournalToFile(_userAnswer);
        }
    }
}