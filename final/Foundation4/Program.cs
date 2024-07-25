using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(new DateTime(2002, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3) ,30, 15.0);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 40);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}