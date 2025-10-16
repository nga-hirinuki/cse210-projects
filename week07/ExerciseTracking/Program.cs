using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> activities = new List<Activity>();

        // Create one activity of each type
        Running run = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Cycling ride = new Cycling(new DateTime(2022, 11, 3), 45, 20.0);
        Swimming swim = new Swimming(new DateTime(2022, 11, 3), 25, 40);

        // Add to list
        activities.Add(run);
        activities.Add(ride);
        activities.Add(swim);

        // Loop and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}