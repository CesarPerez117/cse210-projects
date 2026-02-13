using System;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityTime;

    public Activity()
    {
        _activityName = "";
        _activityDescription = "";
        _activityTime = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_activityDescription}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _activityTime = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet Ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_activityTime} seconds of the {_activityName} Activity.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        int animationIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[animationIndex]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            animationIndex = (animationIndex + 1) % animationStrings.Count;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}