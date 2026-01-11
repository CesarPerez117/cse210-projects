using System;
using System.Collections.Generic; 
using System.Runtime.CompilerServices;

// This will help me to sort

class Program
{
    static void Main(string[] args)
    {
        /* 
        Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        (Remember: You should not add 0 to the list. If you do, later calculations and operations will 
        not be correct.)
        */
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        int sum = 0;


         while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Compute the sum, or total, of the numbers in the list.
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum, or largest, number in the list.
        int largest = 0;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch Challenge
        // I didn't understand how to make the first one so I did the second.

        /* 
            Sort the numbers in the list and display the new, sorted list. Hint: There are C# 
            libraries that can help you here, try searching the internet for them.
        */
        numbers.Sort();
        foreach (int g in numbers)
        {
            Console.WriteLine(g);
        }


    }
}