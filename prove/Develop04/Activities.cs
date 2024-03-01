using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Activities{
    public static List<string> greetings = new List<string> { "Welcome to the ", " Activity." };
    
}

class Breathing : Activities{
    static public void BreathingLogic(){
    string activityName = "Breathing";
    Console.WriteLine(greetings[0], activityName, greetings[1]);
    Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    Console.WriteLine("How long do you want to do this activity for?");
    string timerStr = Console.ReadLine();
    int timerInt = Int32.Parse(timerStr);
    Console.Clear();
    Console.WriteLine("Alright, calm yourself and prepare...");
    Thread.Sleep(1000);
    int timeBreathed = 0;
    while (timeBreathed < timerInt){
        Console.WriteLine("Breathe in... 4");
        Console.Write("\b \b"); 
        Console.Write("3"); 
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("1");
        Thread.Sleep(1000);
        Console.WriteLine("Breathe out... 4");
        Console.Write("\b \b"); 
        Console.Write("3"); 
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("1");
        Thread.Sleep(1000);
        timeBreathed += 8;
    }
    Console.Clear();
    Console.WriteLine("You've completed this breathing excersize.");

    }
}

class Reflection : Activities{
    static public void ReflectionLogic(){
        string activityName = "Reflection";
        Console.WriteLine(greetings[0], activityName, greetings[1]);
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("How long do you want to do this activity for?");
        string timerStr = Console.ReadLine();
        int timerInt = Int32.Parse(timerStr);
        Console.Clear();
        Console.WriteLine("Alright, calm yourself and prepare...");
        Thread.Sleep(1000);
        var prompts = new List<string>()
                    {
                        "Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless."
                    };
        Random random = new Random();
        int randomPrompt = random.Next(0, 4);
        Console.WriteLine(prompts[randomPrompt]);
        Thread.Sleep(3000);
        int timeReflected = 0;

        while (timeReflected < timerInt){
            var questions = new List<string>()
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
            Random rand = new Random();
            int randomQuestion = rand.Next(0, questions.Count);
            Console.WriteLine(questions[randomQuestion]);
            questions.RemoveAt(randomQuestion);
            Thread.Sleep(8000);
            timeReflected += 8;
        }
    }
}

class Listing : Activities{
    static public void ListingLogic(){
        string activityName = "Listing";
        Console.WriteLine(greetings[0], activityName, greetings[1]);
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("How long do you want to do this activity for?");
        string timerStr = Console.ReadLine();
        int timerInt = Int32.Parse(timerStr);
        Console.Clear();
        Console.WriteLine("Alright, calm yourself and prepare...");
        Thread.Sleep(1000);
        var prompts = new List<string>()
                    {
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"
                    };
        Random random = new Random();
        int randomPrompt = random.Next(0, 5);
        Console.WriteLine(prompts[randomPrompt]);
    }
}