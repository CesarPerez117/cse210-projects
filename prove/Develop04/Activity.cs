using System;

public class Activity {

    // Variable that I need to create for the constructor
    private int _timeActivity;

    // Andrew and Vern told me that this is the correct way for the constructor
    public Activity(int timeActivity) 
    {
        // So basically, this will make the difference betwueen the things I do in the base agains the child
        _timeActivity = timeActivity;
    }

    public int ActivityTime() 
    { 
        // Ask and get the entry of the time from the user and return it to store it and use it.
        Console.Write("How long, in seconds, would you like for your session? ");
        int userEntry = int.Parse(Console.ReadLine());
        _timeActivity = userEntry;
        return userEntry;
    }
    public void SetActivityTime(int timeActivity) 
    { // I need this to called it outside
        _timeActivity = timeActivity;
    }

    
    
    public void Spinner() // My peers share me a link with the spinner info to make it like the demo. I will try to set up this, but I am just using the GetReady() 
    {
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(500);
        }
    }

    public void GetReady() // in the video demo, the spinned was used also to get ready, so lets do it. 
    { 
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("Get ready... /"); break;
                case 1: Console.Write("Get ready... -"); break;
                case 2: Console.Write("Get ready... \\"); break;
                case 3: Console.Write("Get ready... |"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 14, Console.CursorTop);
            counter++;
            Thread.Sleep(75);
        }
    }

}