using System;

// Address class
public class Address
{
    private string street;
    private string city;
    private string country;

    public Address(string street, string city, string country)
    {
        this.street = street;
        this.city = city;
        this.country = country;
    }

    public string GetAddress()
    {
        return $"{street}, {city}, {country}";
    }
}

// Base Event class
public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {title}, Date: {date.ToShortDateString()}";
    }
}

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Cityville", "Countryland");

        Lecture lecture = new Lecture("Learn to Code", "Join us for an informative session on coding", 
            new DateTime(2023, 5, 15), new TimeSpan(14, 0, 0), address1, "John Doe", 50);

        Reception reception = new Reception("Networking Event", "Meet and greet with industry professionals", 
            new DateTime(2023, 6, 10), new TimeSpan(18, 30, 0), address1, "rsvp@example.com");

        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy a day outdoors with food and games", 
            new DateTime(2023, 7, 20), new TimeSpan(12, 0, 0), address1, "Sunny");

        Console.WriteLine("Lecture Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(gathering.GetShortDescription());
    }
}
