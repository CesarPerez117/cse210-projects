using System;
using System.Diagnostics;

public class ReflectingActivity : Activity 
{

    //private string _prompt;
    //private string _question;

    public ReflectingActivity(int timeActivity) : base(timeActivity)
    { // calling the constructor for the timer
    }

    Activity activity = new Activity(0);
    private List<string> _promptList = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };

    private List<string> _questionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void ActivityPrompt()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    // I need to get a random prompt, also, create a random for the questions. 
    private string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    } 

    private string RandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questionList.Count);
        return _questionList[index];
    }

    public void ShowPrompt(int seconds)
    {
        string prompt = RandomPrompt();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void ShowQuestions(int seconds) // I wasn't able to fix this one on time
    {
        int timer = 0;
       Console.WriteLine($"\nNow ponder on each of the following questions as they related to this experience.");
       Thread.Sleep(800); 
       Console.Clear();
       while (timer < seconds)
       {
        timer += 4;
        if (timer == seconds)
        {
            break;
        }
        if (timer != seconds)
        {
            string question = RandomQuestion();
            Console.Write($"\n> {question}");
            activity.Spinner(); 
        }
       }
       
    }
}
