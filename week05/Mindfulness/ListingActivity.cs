using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class ListingActivity : Activity
{
    private int _count;
    public ListingActivity()
    {
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    }
    private List<string> _promptList = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);
        Console.WriteLine($"\n--- {_promptList[index]} ---");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_activityTime);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();

    }
}