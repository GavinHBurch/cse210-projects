using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address( "50 W Viking St", "Rexburg", "ID", "United States of America");

        Lecture lecture = new Lecture("Devotional for BYU-Idaho", "Not Blinds Faith, but Big Faith", "January 14, 2023", "7 PM", address, "President Henry J Eyring", 15000);

        Console.WriteLine();

        Console.WriteLine("Event Number: 1");

        Console.WriteLine();

        Console.WriteLine(lecture.GetStandard());

        Console.WriteLine();

        Console.WriteLine(lecture.GetLecture());

        Console.WriteLine();

        Console.WriteLine(lecture.GetShortLecture());

        Address addressR = new Address( "886 W 2600 N", "Pleasant Grove", "UT", "United States of America");

        Reception reception = new Reception("Wedding Ceremony", "Gavin and Carlie's Wedding", "March 13, 2020", "5:30 PM", addressR, "gburch1@alpineschooldistrict.org");

        Console.WriteLine();

        Console.WriteLine("Event Number: 2");

        Console.WriteLine();

        Console.WriteLine(reception.GetStandard());

        Console.WriteLine();

        Console.WriteLine(reception.GetReception());

        Console.WriteLine();

        Console.WriteLine(reception.GetShortReception());

        Address addressOG = new Address( "851 E 700 N", "American Fork", "UT", "United States of America");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Harrington Center for the Arts", "Concerts in the Park", "June 24, 2020", "2 PM", addressOG, "sunny");

        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();

        Console.WriteLine(outdoorGathering.GetStandard());

        Console.WriteLine();

        Console.WriteLine(outdoorGathering.GetOutdoorGathering());

        Console.WriteLine();

        Console.WriteLine(outdoorGathering.GetShortOutdoorGathering());
    }
}