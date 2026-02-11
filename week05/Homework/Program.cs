using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Miguel Gonzales","Factorization Cases");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "5.2", "22-23");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Mariana Luna", "Historia Colombiana", "Errores de la Democracia");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
        Console.WriteLine();
    }
}