using System;

// My team pers told me that if I storage the user entry in a list in another class
// I will be able to display it for 2nd option. 
public class StorageJournal
{
    public List<JournalEntry> _storageJournal = new List<JournalEntry>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public StorageJournal()
    {
    }
    
    public void Display()
    {

        foreach (JournalEntry journalEntry in _storageJournal)
        {
            journalEntry.Display();
        }    
    }   
}