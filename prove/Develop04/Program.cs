using System;
using System.Diagnostics;
using System.Reflection;

class Program
{
    static int ShowMenu()
    {
        Console.WriteLine("Select Option: \n 1. Breathing Activity \n 2. Reflection Activity \n 3. Listing Activity \n 4. Quit \n 5. Crash the Program");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    static public void Run()
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            var selection = ShowMenu();
            if (selection == 1)
            {
                Breathing.BreathingLogic();
            }
            else if (selection == 2)
            {
                Reflection.ReflectionLogic();
            }
            else if (selection == 3)
            {
                Listing.ListingLogic();
            }
            else if (selection == 4)
            {
                keepGoing = false;
            }
        }
    }
}