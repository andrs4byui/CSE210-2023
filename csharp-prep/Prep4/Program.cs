using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int theNumberInput;
        
        do
        {
            Console.Write("Enter number: ");
            String input = Console.ReadLine();
            theNumberInput = int.Parse(input);
            if (theNumberInput == 0)
                {
                    int sumOfList = numbers.AsQueryable().Sum();
                    Console.WriteLine($"the sum is: {sumOfList}");
                    //Console.WriteLine($"The average is: ${}");
                    //Console.WriteLine($"The largest number is: ${}");
                }
            else 
                {
                    numbers.Add(theNumberInput);

                }
        } while (theNumberInput != 0);
    }
}