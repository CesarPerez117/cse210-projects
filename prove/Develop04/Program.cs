using System;

class Program
{
    static void Main(string[] args)
    {   
        int timeActivity = 0;
        int choice = 0;
        int seconds;
        do{
            Activity activity = new Activity(timeActivity);
            Console.Clear();

            // Display menu with the options available
            Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            // store the choice in the variable and as integer
            choice = int.Parse(Console.ReadLine());

            
            switch (choice)
            {
                case 1: // Breathing activity
                Console.Clear();
                    Console.WriteLine("Welcome to the Breathing Activity.\n");
                    BreathingActivity breathingActivity = new BreathingActivity(0);
                    breathingActivity.ActivityPrompt();
                    seconds = activity.ActivityTime();
                    breathingActivity.GetReady();
                    breathingActivity.BreathingExercise(seconds);
                    Console.WriteLine($"\nYou have completed another {seconds} seconds of the Breathing Activity!");
                    Thread.Sleep(7000);
                    break;
                case 2: // Reflecting activity
                    Console.Clear();    
                    Console.WriteLine("Welcome to the Reflecting Activity.\n");
                    ReflectingActivity reflectingActivity = new ReflectingActivity(0);
                    reflectingActivity.ActivityPrompt();
                    seconds = activity.ActivityTime();
                    reflectingActivity.GetReady();
                    reflectingActivity.ShowPrompt(seconds);
                    reflectingActivity.ShowQuestions(seconds);
                    Console.WriteLine($"\nYou have completed another {seconds} seconds of the Reflecting Activity!");
                    Thread.Sleep(7000);
                    break;
                case 3: // Listing activity
                    Console.Clear();
                    Console.WriteLine("Welcome to the Listing Activity.");
                    break;
                case 4: // Quit the app
                    Console.WriteLine("Thanks for the try. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }
        } while (choice != 4);
    }
}