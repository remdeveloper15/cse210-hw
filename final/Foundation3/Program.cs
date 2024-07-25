using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------------EVENTS PLANNER----------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------------EVENTS----------------------------------------------------------------");
        Console.WriteLine("We affer different kind of Event. We will organize and preparar all for you! We offer the following types of events: ");
        Lecture lecture = new Lecture("LECTURES", "Event Lectures is a appropiate to Speaches or Declamations! This event count with a speaker, provided by our agency and also have a limted capacity, in order to keep the order.", "Lecture Events are avaible from Monday to Saturday. ", "Lecture Events have a limit of 3 hours booking reservation, for events that are in the night,they will end at least 1 hour before 8:00PM. ", "130 Bowery, New York, NY 10013, Estados Unidos", "200", "Mindy Weiss");
        OutdoorGathering outdoorGathering = new OutdoorGathering("OUTDOOR GATHERING", "Outdoor Gathering is perfect to events such as Party Birhtday, Marriage, and all kind of especial event with a several amount of persona, because there is not a limit on attendees, however, it will be essential and is need it to track the weather forecast in order to avoid a desaster.", "Outdoor Gathering Events are avaible just for Weekends.", "OutDoor Gathering time will be determinated by the track of the weather forecast.", "3485 S Main St, Salt Lake City, UT 84115, United States", "We remind you that all the cirscunstance with this kind of event, such as, capacity, time limit, date, and so on, will be statement according weather forecast. ");
        Reception reception = new Reception("RECEPTION", "If you want to make something like a special Dinner, or maybe a Family Meeting, you will be interested in Receptions events. In order to keep the organization, is require to people who will attended ti the event will be register previouslyn or make and confirmation to the Event, at least three days before it.", "Reception Events are avaible Tuesday, Friday and Saturday", "Reception Events could be any hour that you decided. Commonly these events are book to night, and the time limit is until 02:00 AM", "14201 H Dr N, Battle Creek, MI 49014, Estados Unidos", "helamanfranco@hotmail.com");
        lecture.DisplayStandardDetails();
        lecture.DisplayFullDetail();
        lecture.DisplayShortDescription();
        outdoorGathering.DisplayStandardDetails();
        outdoorGathering.DisplayFullDetail();
        outdoorGathering.DisplayShortDescription();
        reception.DisplayStandardDetails();
        reception.DisplayFullDetail();
        reception.DisplayShortDescription();

        
    }
}