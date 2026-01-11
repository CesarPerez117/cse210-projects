using System;

class Program
{
    static void Main(string[] args)
    {

        /*
        Ask the user for their grade percentage, then write a series of if, else if, else statements to 
        print out the appropriate letter grade. 
        */

        Console.Write("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int userGrade = int.Parse(userAnswer);
        string gradeLetter  = "";

        /*
        Console.WriteLine($"Your grade is: {letter}");

        if (userPercentage > 70)
        {
            Console.WriteLine("Congratulations, you have pass the course!");
        }
        else if (userPercentage < 70)
        {
            Console.WriteLine("Sorry, you fail the course. Encourage next time.");
        }

        Assume that you must have at least a 70 to pass the class. After determining the letter grade 
        and printing it out, add a separate if statement to determine if the user passed the course, 
        and if so, display a message to congratulate them. If not, display a different message to 
        encourage them for next time.
        */

        if (userGrade >= 90 && userGrade < 100)
        {
            gradeLetter = "A";

            if (userGrade >= 97)
            {
                gradeLetter = "A+";
            }
            else if (userGrade <= 93)
            {
                gradeLetter = "A-";
            } 
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            gradeLetter = "B";

            if (userGrade >= 87)
            {
                gradeLetter = "B+";
            }
            else if (userGrade <= 83)
            {
                gradeLetter = "B-";
            }
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            gradeLetter = "C";

            if (userGrade >= 77)
            {
                gradeLetter = "C+";
            }
            else if (userGrade <= 73)
            {
                gradeLetter = "C-";
            }
        }
        else if (userGrade >= 60 && userGrade < 70)
        {
            gradeLetter = "D";

            if (userGrade >= 67)
            {
                gradeLetter = "D+";
            }
            else if (userGrade <= 63)
            {
                gradeLetter = "D-";
            }
        }
         else if (userGrade < 60)
        {
                gradeLetter = "F";
        }
        
        Console.WriteLine($"Your grade is: {gradeLetter}");
        if (userGrade > 70)
        {
            Console.WriteLine("Congratulations, you have pass the course!");
        }
        else if (userGrade < 70)
        {
            Console.WriteLine("Sorry, you fail the course. Encourage next time.");
        }

    }
}