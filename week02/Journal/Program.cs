using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0; //variable completely related with the switch menu
        JournalPrompt journalPrompt = new JournalPrompt();
        Journal journal = new Journal();
         JournalLoad journalLoad = new JournalLoad();

        Console.WriteLine("Welcome to the Journal Program!");

         // Interactive menu
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write" +
            "\n2. Display" + 
            "\n3. Load" + 
            "\n4. Save" +
            "\n5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    // first, store the random prompt in a string variable
                    string randomPrompt = journalPrompt.GetRandomPrompt();
                    DateTime theCurrentTime = DateTime.Now; // call de DateTime method
                    string dateNow = theCurrentTime.ToShortDateString(); // and store it in a variable

                    JournalEntry journalEntry = new JournalEntry(); // How is that called? Invoke?
                    // but, I "invoked" here for been able to attach the info to the journal entry:
                    journalEntry._dateTime = dateNow;
                    journalEntry._promptText = randomPrompt;

                    Console.WriteLine($"{randomPrompt}");
                    Console.Write("> ");
                
                    // now I will save the answer as userEntry and send it to the journalEntry
                    string userEntry = Console.ReadLine();
                    journalEntry._entryText = userEntry;
                    // also I will send the whole journalEntry, already filled, to a list for store and display porpuses
                    journal._journalSave.Add(journalEntry);
                    break;

                case 2:
                    journalLoad.Display(); // this one displays what I have on a loaded file
                    // the origin of this is explained in case #3
                    journal.Display(); // this one displays what I just writed in the journalEntry
                    break;

                case 3:
                    journal.LoadFile(); // it executes the method to get and load a file.txt
                    string load = journal._readText;
                    journalLoad._loadedText = load;
                    // What is happening here? Is long, was the only solution I thought, take seat:
                    // In the Journal() class, we have a method called LoadFile(), and his work is to load a file
                    // base on the info user provides. Then, we store the file in _readText after using File.ReadAllText(_fileName).
                    // _readText was oppened as an attribute of Journal(), Why? For been able to call it here.
                    // We now store the _readText inside the load variable and then, we send the load variable to the class JournalLoad().
                    // Now in JournalLoad(), we received the text in the _loadedText attribute, and pass it to the display function. 
                    break;

                case 4:
                    journal.CreateFile(); // This function is explaioned (origin and reason) on the Journal.CS file.
                    break;
            } 
        } while (choice != 5);
    }
}