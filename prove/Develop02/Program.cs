using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        journal = new Journal();
        Run();
    }
    static int ShowMenu()
    {
        Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries \n 3. Save Entry \n 4. Mystery Button \n 5. Quit");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    static public Journal journal;


    static public string GetPrompt()
    {
        var prompts = new List<string>()
                    {
                        "Had any interesting thoughts today?",
                        "Who was the most interesting person you met?",
                        "What MnM are you feeling today?",
                        "Anything you forgot to do today?",
                        "What quote are you feeling today?",
                    };
        Random random = new Random();
        int randomPrompt = random.Next(0, 5);
        return prompts[randomPrompt];
    }

    static public void Run()
    {
        bool keepGoing = true;

        while (keepGoing)
        {
            var selection = ShowMenu();

            if (selection == 1)
            {
                
                //Prompt user with a random prompt
                var prompt = GetPrompt();
                //Read in user input
                var placeholderResponse = GetPrompt();

                var entry = new Entry(placeholderResponse, prompt);
                journal.AddEntry(entry);
            }
            else if (selection == 2)
            {
                Console.WriteLine(Journal.entries);
            }
            else if (selection == 3)
            {
                SaveToFile();
            }
            else if (selection == 4)
            {
                //mystery button
            }
            else if (selection == 5)
            {
                keepGoing = false;
            }
        }
    }


    static public void SaveToFile()
    {
        using(StreamWriter writetext = new StreamWriter("journal.txt"))
        {
            writetext.WriteLine();
        }
    }

    static public void LoadFromFile()
    {

    }
}