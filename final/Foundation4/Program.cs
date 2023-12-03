using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<Activity> activities = new List<Activity>();

            RunningActivity runningActivity = new RunningActivity("2023-12-03", 120, 12);
            activities.Add(runningActivity);

            CyclingActivity cyclingActivity = new CyclingActivity("2023-12-03", 120, 12);
            activities.Add(cyclingActivity);

            SwimmingActivity swimmingActivity = new SwimmingActivity("2023-12-03", 120, 12);
            activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
    }
}