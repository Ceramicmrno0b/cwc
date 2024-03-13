using System;
using System.Diagnostics;
using System.Reflection;

class Program
{
    static int ShowMenu()
    {
        Console.WriteLine("Select Option: \n 1. Edit Eternal Goal \n 2. Edit Simple Goal \n 3. Edit Checklist Goal \n 4. View all Goals \n 5. Quit");
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
                Console.WriteLine("Select Option: \n 1. Create Eternal Goal \n 2. Complete Eternal Goal \n 3. Back");
                string input = Console.ReadLine();
                Eternal Eternal = new Eternal();
                while (keepGoing){
                    if (selection == 1){
                    Eternal.EternalSet();
                    }
                    if (selection == 2){
                    Eternal.EternalComplete();
                    }
                    if (selection == 3){
                    keepGoing = false;
                    }
                }
            }
            else if (selection == 2)
            {
                Console.WriteLine("Select Option: \n 1. Create Simple Goal \n 2. Complete Simple Goal \n 3. Back");
                string input = Console.ReadLine();
                Simple Simple = new Simple();
                while (keepGoing){
                    if (selection == 1){
                    Simple.SimpleSet();
                    }
                    if (selection == 2){
                    Simple.SimpleComplete();
                    }
                    if (selection == 3){
                    keepGoing = false;
                    }
                }
            }
            else if (selection == 3)
            {
                Console.WriteLine("Select Option: \n 1. Create Checklist Goal \n 2. Complete Checklist Goal \n 3. Back");
                string input = Console.ReadLine();
                Checklist Checklist = new Checklist();
                while (keepGoing){
                    if (selection == 1){
                    Checklist.ChecklistSet();
                    }
                    if (selection == 2){
                    Checklist.ChecklistComplete();
                    }
                    if (selection == 3){
                    keepGoing = false;
                    }
                }
            }
            else if (selection == 4)
            {
            Checklist Checklist = new Checklist();
            Simple Simple = new Simple();
            Eternal Eternal = new Eternal();
                Simple.ListSimple();
                Eternal.ListEternal();
                Checklist.ListChecklist();
            }
            else if (selection == 5)
            {
                keepGoing = false;
            }
        }
    }
}