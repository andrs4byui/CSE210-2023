using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("LECTURE EVENT");
        Console.WriteLine("---------------------------------------------------");
        LectureEvent lectureEvent = new LectureEvent("Lecture Event", "The Friday Lecture Event", "An event where anyone is invited but capacity is not unlimited", "Friday Apr 7", "10:00am", "Andres Soruco", 75);
        lectureEvent.Address = new Address("1652 South Avenue", "Salt Lake", "Utah", "USA");
        lectureEvent.StandardDetails();
        Console.WriteLine();
        Console.WriteLine("*************");
        Console.WriteLine("All details");
        Console.WriteLine("*************");
        lectureEvent.FullDetails();
        Console.WriteLine();
        Console.WriteLine("*************");
        Console.WriteLine("Short Description");
        Console.WriteLine("*************");

        lectureEvent.ShortDescription();
        Console.WriteLine("");

        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("RECEPTION EVENT");
        Console.WriteLine("---------------------------------------------------");
        ReceptionEvent receptionEvent = new ReceptionEvent("Reception Event", "The Reception", "A reception event that only has RSVP people", "Saturday Apr 8", "16:00PM", 
        "Dear invited, This email is meant to ask for your confirmation to the Reception event comming. Please Confirm");
        receptionEvent.Address = new Address("1125 Calle Oruro", "Tarija", "Tarija", "Bolivia");
        receptionEvent.StandardDetails();
        Console.WriteLine();
        Console.WriteLine("*************");
        Console.WriteLine("All details");
        Console.WriteLine("*************");
        receptionEvent.FullDetails();
        Console.WriteLine();
        Console.WriteLine("*************");
        Console.WriteLine("Short Description");
        Console.WriteLine("*************");
        receptionEvent.ShortDescription();
        Console.WriteLine("");

        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("OUTDOOR EVENT");
        Console.WriteLine("---------------------------------------------------");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Outdoor Event", "Come Out", "An outdoor Event where you will enjoy the view and you will learn something", "Saturday Apr 8", "16:00PM", 30, 14, 15, 20, 2);
        outdoorEvent.Address = new Address("1826 Pedro Valdivia", "Calama", "Antofagasta", "Chile");
        outdoorEvent.StandardDetails();
        Console.WriteLine();
        Console.WriteLine("*************");
        Console.WriteLine("All details");
        Console.WriteLine("*************");
        outdoorEvent.FullDetails();
        Console.WriteLine();
        Console.WriteLine("*************");
        Console.WriteLine("Short Description");
        Console.WriteLine("*************");
        outdoorEvent.ShortDescription();
    }
}