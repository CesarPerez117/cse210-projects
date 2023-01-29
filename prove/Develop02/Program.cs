using System;

class Program
{
    static void Main(string[] args)
    {
        // First I need to create the menu.
        int choice = 0;
        // Display the welcome prompt
        Console.WriteLine("Welcome to the Journal Program!");

        JournalPrompts journalPrompts = new JournalPrompts();
        StorageJournal storageJournal = new StorageJournal();

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
                    // I need to display a random prompt and then storage 
                    // the user answer in a variable.
                    string prompt = journalPrompts.DisplayPrompt();
                    string dateNow = GetDateTime();
                    // In last meeting I learned that will be better if I 
                    // storage the journal entry in other class, that will call StorageJournal()
                    // in the same way I learned:
                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry._dateTime = dateNow;
                    journalEntry._journalPrompt = prompt;
                    Console.WriteLine($"{prompt}");
                    Console.Write("> ");
                    // Now I need to get the journalAnswer putting the answer in a variable answer
                    // and sending it to JournalDisplay(). To avoid confusion, I will change the class
                    // name JournalDisplay to JournalEntry. 
                    string answer = Console.ReadLine();
                    journalEntry._journalAnswer = answer;
                    storageJournal._storageJournal.Add(journalEntry);

                    break;
                case 2:
                    // I need to get the information saved in the variable
                    // or in the file to display the current journal.
                    storageJournal.Display();
                    //Console.WriteLine("You choose Display");

                    break;
                case 3:
                    // I need to find and get back the file with the journal record
                    storageJournal.LoadFile();
                    //Console.WriteLine("You choose Load");
                    break;
                case 4:
                    // I need to save the answers with the prompt and date
                    // and create a new file or storage in an existant one
                    storageJournal.CreateFile();
                    //Console.WriteLine("You choose Save");
                    break;
                default:
                    // This will be to solve any problem if user place a different value.
                    Console.WriteLine("Chose a valid option");
                    break;
            }
        } while (choice != 5);

        // I need to obtain the exact date and time so I will call the class here:
        static string GetDateTime() // I need to return the value, that's VS says to work. 
        {
            DateTime theCurrentTime = DateTime.Now;
            string currentTime = theCurrentTime.ToString();
            return currentTime;
        }

    }
}