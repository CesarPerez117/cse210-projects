using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Prompt the user for their first name. Then, prompt them for their last name. Display the text back 
        all on one line saying, "Your name is last-name, first-name, last-name" as shown:

        What is your first name? Scott
        What is your last name? Burton

        Your name is Burton, Scott Burton.
        */

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}