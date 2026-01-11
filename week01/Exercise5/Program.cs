using System;

class Program
{
    static void Main(string[] args)
    {
        // For this assignment, write a C# program that has several simple functions:
        DisplayWelcome(); /* if the program just will send information when needed, 
        we just need to call the function  */


        string userName = PromptUserName(); /* if the function uses info and return that info, we need 
        store the info into variables in the main */

        int userNumber = PromptUserNumber(); /* This first connect with the function, when got the info from
        the user, is store here so it can be use as parameter for Display */

        int squareNumber = SquareNumber(userNumber); /* This first connect with the function, when got the info from
        the user, is store here so it can be use as parameter for Display */

        DisplayResult(userName, squareNumber); /* the parameters will need to accomplish his order or will not work 
        and cannot debug */
    }

    // 1) DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // 2) PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
        
    // 3) PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
     static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    // 4) SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
     static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    // 5) DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}