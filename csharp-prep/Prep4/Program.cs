using System;
// This libraries are needed to call the methods of Sum, Average
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
                    double listAverage = Queryable.Average(numbers.AsQueryable());
                    int maxValue = numbers.Max();
                    Console.WriteLine($"the sum is: {sumOfList}");
                    Console.WriteLine($"The average is: {listAverage}");
                    Console.WriteLine($"The largest number is: {maxValue}");

                    //Strech Chanllenge
                    int minValue = numbers.Min();
                    
                    Console.WriteLine($"Smallest positive number is: {minValue}");
                    numbers.Sort();
                    Console.WriteLine("the sorted list is:");
                    foreach (int number in numbers)
                        {
                        Console.WriteLine(number);
                        };
                
                //    void theMinNumber()
                //        {
                //        numbers.Sort();
                //        int minPossibleValue = 1;
                //        foreach ( int number in numbers) {
                //            if (number < 1)
                //                {
                //                    
                //                };
                //        };
                }
            else 
                {
                    numbers.Add(theNumberInput);

                }
            

        } while (theNumberInput != 0);


    }
}