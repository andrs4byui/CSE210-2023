using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "software Engineer";
        job1._companyName = "Microsoft";
        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._companyName = "Apple";

        Console.WriteLine($"{job1._jobTitle} at {job1._companyName}");
        Console.WriteLine($"{job2._jobTitle} at {job2._companyName}");

    }
}