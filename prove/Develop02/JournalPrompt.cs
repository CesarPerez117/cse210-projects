using System;

public class JournalPrompts
{
    // 1. Create the prompt list
    public List<string> _listOfPrompts = new List<string>()
    {
        "What is something that I want to remember from today?",
        "What is something that I learned today?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?"
    };

    //public void Display()
    //{   // 2. Select a random prompt
        //Random random = new Random();
        //int value = random.Next(6);
        // 3. DIsplay the random prompt
        //string randomPrompt = _listOfPrompts[value];
        //Console.WriteLine(randomPrompt);
        //string userPrompt = randomPrompt;
       // string userAnswer = Console.ReadLine();
    //}

    public string DisplayPrompt()
    {
        // we learned this last team meeting...
        // 2. Select a random prompt
        Random random = new Random();
        int value = random.Next(_listOfPrompts.Count);
        // 3. DIsplay the random prompt
        string journalPrompt = _listOfPrompts[value];
        return journalPrompt;
    }
    
}