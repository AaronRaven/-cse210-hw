using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        LectureEvent lectureEvent = new LectureEvent("Natural science lecture", "A lecture about natural sciences", "2024 01 24", "2PM", "Aaron Ravenson", 120);
        lectureEvent.SetAddress("Hollywood", "Los Angeles", "California", "USA");
        events.Add(lectureEvent);    
        

        ReceptionEvent receptionEvent = new ReceptionEvent("Reception Event", "A reception for very special ocasion", "2024 03 24", "3PM", "Aaron@mail.com");
        receptionEvent.SetAddress("Downtown Miami", "Miami", "Florida", "USA");
        events.Add(receptionEvent);


        OutdoorEvent outdoorEvent = new OutdoorEvent("Outdoor party", "An event taking place in New York Central Park", "2024 06 24", "1PM", "Sunny and very warm");
        outdoorEvent.SetAddress("Central Park", "New York City", "New York", "USA");
        events.Add(outdoorEvent);



        foreach (Event event_ in events)
        {
            Console.WriteLine(event_.GetStandardDetails() + "\n");
        }
        foreach (Event event_ in events)
        {
            Console.WriteLine(event_.GetShortDescription());
        }
        foreach (Event event_ in events)
        {
            Console.WriteLine(event_.GetFullDetails() + "\n");
        }   
    }
}