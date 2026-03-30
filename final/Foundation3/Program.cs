using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup Addresses
        Address addr1 = new Address("123 Tech Lane", "Silicon Valley", "CA", "USA");
        Address addr2 = new Address("456 Party Blvd", "Madrid", "MD", "Spain");
        Address addr3 = new Address("789 Nature Path", "Vancouver", "BC", "Canada");

        // Create specific events
        Lecture lecture = new Lecture("AI Future", "Exploring the next decade of AI.", "2026-05-10", "10:00 AM", addr1, "Dr. Smith", 200);
        Reception reception = new Reception("Networking Night", "A chance to meet local founders.", "2026-06-15", "06:30 PM", addr2, "rsvp@startup.com");
        OutdoorGathering outdoor = new OutdoorGathering("Summer Picnic", "Community gathering in the park.", "2026-07-20", "12:00 PM", addr3, "Sunny with a light breeze");

        // Create a list to iterate through them
        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\nSHORT DESCRIPTION:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("========================================\n");
        }
    }
}