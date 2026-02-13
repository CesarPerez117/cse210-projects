using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_activityTime);
        
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.Write("\nBreathe in...");
            ShowCountDown(3);
            Console.Write("\nBreathe out...");
            ShowCountDown(4);   
        }

        Console.Clear();
        DisplayEndingMessage();
    }
}