using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice != 4)
        {

            Console.WriteLine("Welcome to the self-care app!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing exercise");
            Console.WriteLine("2. Reflection exercise");
            Console.WriteLine("3. Listing exercise");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunStartingSequence();
                breathingActivity.RunActivity();
                breathingActivity.RunEndingSequence();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.RunStartingSequence();
                reflectionActivity.RunActivity();
                reflectionActivity.RunEndingSequence();                
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunStartingSequence();
                listingActivity.RunActivity();
                listingActivity.RunEndingSequence();                
            }
        }
    }
}