using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Breathing activity
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case 2: // Reflecting activity
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case 3: // Listing activity
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 4: // Quit the app
                    Console.WriteLine("Thanks for the try. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }

        } while(choice != 4);
    }
}