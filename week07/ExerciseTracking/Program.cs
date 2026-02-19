using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Exercise Record!\n");

        // Running
        Running runningE = new Running("Running", "03 Nov 2025", 30, 4.8);
        Running running =  new Running("Running", "05 Oct 2025", 25, 2.2);

        // Cycling 
        Cycling cycling = new Cycling("Cycling", "02 Dec 2025", 62, 22);

        // Swimming 
        Swimming swimming = new Swimming("Swimming", "05 Jun 2025", 15, 12);

        Console.WriteLine("Let's Display the Summary: \n");

        var exerciseList = new List<Activity> {runningE, running, cycling, swimming};

        foreach (var exercise in exerciseList)
        {
            Console.WriteLine($"{exercise.DisplaySummary()}\n");
        }
    }
}