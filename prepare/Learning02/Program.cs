using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2026;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._companyName = "Apple";
        job2._startYear = 20230;
        job2._endYear = 2040;

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._personName = "Andres Soruco";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();


    }
}