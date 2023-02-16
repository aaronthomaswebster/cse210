using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("123 Main St", "Anytown", "USA", "12345");
        Address address2 = new Address("456 Main St", "Anytown", "USA", "12345");
        Address address3 = new Address("789 Main St", "Anytown", "USA", "12345");

        Lecture lecture = new Lecture(
            "C# 101", "Learn C# basics", 
            new DateOnly(2023, 3, 1), 
            new TimeOnly(17, 0), 
            address1, 
            "Aaron Webster", 
            100
        );
        Reception reception = new Reception(
            "Wedding Reception",
            "The marrige of 2 people in love",
            new DateOnly(2023, 3, 1),
            new TimeOnly(17, 0),
            address2,
            "receptions@wedding.com"
        );
        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Camping Trip",
            "Snowshoeing in the mountains and camping under the stars",
            new DateOnly(2023, 3, 1),
            new TimeOnly(17, 0),
            address2,
            "Sunny with a high of 45"
        );

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        foreach(Event e in events){
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(e.ShortDetails());
            Console.WriteLine();
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.FullDetails());
        }
    }
}