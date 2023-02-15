using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine("*************************"); 

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary()); // The MathAssignment instance inherits the getSumary object from the Assignment Class.
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine("*************************"); 

        //Test for Writing assignment 
        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary()); //The writingAssignment1 instance inherits the getSumary object from the Assignment Class.
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}