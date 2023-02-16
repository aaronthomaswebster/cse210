using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateOnly(2023,3,1), 30, 6));
        activities.Add(new Cycling(new DateOnly(2023,3,2), 20, 12));
        activities.Add(new Swimming(new DateOnly(2023,3,3), 30, 35));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}