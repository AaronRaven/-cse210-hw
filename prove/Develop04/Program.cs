using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the self-care app!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing exercise");
            Console.WriteLine("2. Reflection exercise");
            Console.WriteLine("3. Listing exercise");
            Console.WriteLine("4. Display report");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunStartingSequence();
                breathingActivity.RunActivity();
                breathingActivity.RunEndingSequence();
            }
            else if (choice == 2)
            {
                Console.Clear();
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.RunStartingSequence();
                reflectionActivity.RunActivity();
                reflectionActivity.RunEndingSequence();                
            }
            else if (choice == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunStartingSequence();
                listingActivity.RunActivity();
                listingActivity.RunEndingSequence();                
            }
            else if (choice == 4)
            {
                Activity.DisplayReport();
            }
        }
    }
}