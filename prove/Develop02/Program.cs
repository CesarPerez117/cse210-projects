using System;

class Program
{
    static void Main(string[] args)
    {
        // First I need to create the menu.
        int choice = 0;
        // Display the welcome prompt
        Console.WriteLine("Welcome to the Journal Program!");

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

            JournalPrompts journalPrompts = new JournalPrompts();
            switch (choice)
            {
                case 1:
                    // I need to display a random prompt and then storage 
                    // the user answer in a variable.
                    journalPrompts.Display();
                   
                    break;
                case 2:
                    // I need to get the information saved in the variable
                    // or in the file to display the current info.
                    Console.WriteLine("You choose Display");

                    break;
                case 3:
                    // I need to find and get back the file with the journal record
                    Console.WriteLine("You choose Load");
                    break;
                case 4:
                    // I need to save the answers with the prompt and date
                    // and create a new file or storage in an existant one
                    Console.WriteLine("You choose Save");
                    break;
                default:
                    // This will be to solve any problem if user place a different value.
                    Console.WriteLine("Chose a valid option");
                    break;
            }
        } while (choice != 5);
    }
}