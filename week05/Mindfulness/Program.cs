using System;

class Program
{
    static void Main(string[] args)
    {
        // I tried to be creative by adding a session counter to track how many mindfulness activities are completed.
        int completedActivities = 0;

        while (true)
        
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                completedActivities++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                completedActivities++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                completedActivities++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                Console.WriteLine($"I completed {completedActivities} mindfulness activities today.");
                Console.WriteLine("Have a peaceful day!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                Thread.Sleep(2000);
            }
        }
    }
}