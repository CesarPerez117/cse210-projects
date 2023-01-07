using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        Console.Write("What is your grade porcentage? ");
        string grade = Console.ReadLine();

        int gradeValue = int.Parse(grade);

        string gradeLetter = "";
        string sign = "";

        if (gradeValue >= 90)
        {
            gradeLetter = "A";
            if (gradeValue >= 97 && gradeValue <= 100)
            {
                sign = "+";
            }
            else if (gradeValue >= 90 && gradeValue <= 93 )
            {
                sign = "-";
            }
        }
        else if (gradeValue >= 80)
        {
            gradeLetter = "B";
            if (gradeValue >= 87 && gradeValue <= 90)
            {
                sign = "+";
            }
            else if (gradeValue >= 80 && gradeValue <= 83 )
            {
                sign = "-";
            }
        }
        else if (gradeValue >= 70)
        {
            gradeLetter = "C";
            if (gradeValue >= 77 && gradeValue <= 80)
            {
                sign = "+";
            }
            else if (gradeValue >= 70 && gradeValue <= 73 )
            {
                sign = "-";
            }
        }
        else if (gradeValue >= 60)
        {
            gradeLetter = "D";
            if (gradeValue >= 67 && gradeValue <= 70)
            {
                sign = "+";
            }
            else if (gradeValue >= 60 && gradeValue <= 63 )
            {
                sign = "-";
            }
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        Console.WriteLine($"Your grade is: {gradeLetter}{sign}");


         if (gradeValue >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else if (gradeValue < 70)
        {
            Console.WriteLine("You didn't pass the class.");
        }
    }
}