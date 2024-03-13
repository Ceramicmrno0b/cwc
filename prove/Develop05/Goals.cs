using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Goals{
    protected string goalTitle;
    protected string goalDesc;
    protected int pointValue;
    protected int points;
}
public class Eternal : Goals{
    public void EternalSet(){
        Console.WriteLine("What would you like to name the eternal goal?");
        string newValue = Console.ReadLine();
        goalTitle = newValue;
        Console.WriteLine("What would you like to be the description for the eternal goal?");
        newValue = Console.ReadLine();
        goalDesc = newValue;
        Console.WriteLine("How many points should you get for completing the eternal goal?");
        newValue = Console.ReadLine();
        pointValue = int.Parse(newValue);
    }
    public void ListEternal(){
        Console.WriteLine($"Eternal Goal: {goalTitle}, {goalDesc}. Worth {pointValue} points per completion.");
    }
    public void EternalComplete(){
        points += pointValue;
        Console.WriteLine($"Congrats, you finished {goalTitle}, and got {pointValue} points!");
    }
}

public class Simple : Goals{
    bool completed;
    public void SimpleSet(){
    completed = false;
        Console.WriteLine("What would you like to name the simple goal?");
        string newValue = Console.ReadLine();
        goalTitle = newValue;
        Console.WriteLine("What would you like to be the description for the simple goal?");
        newValue = Console.ReadLine();
        goalDesc = newValue;
        Console.WriteLine("How many points should you get for completing the simple goal?");
        newValue = Console.ReadLine();
        pointValue = int.Parse(newValue);
    }
    public void ListSimple(){
        Console.WriteLine($"Simple Goal: {goalTitle}, {goalDesc}. Worth {pointValue} points per completion.");
    }
    public void SimpleComplete(){
        completed = true;
        points += pointValue;
        Console.WriteLine($"Congrats, you finished {goalTitle}, and got {pointValue} points!");
    }
}
public class Checklist : Goals{
    bool completed;
    int bonusPoints;
    int repeats;
    public void ChecklistSet(){
    completed = false;
        Console.WriteLine("What would you like to name the checklist goal?");
        string newValue = Console.ReadLine();
        goalTitle = newValue;
        Console.WriteLine("What would you like to be the description for the checklist goal?");
        newValue = Console.ReadLine();
        goalDesc = newValue;
        Console.WriteLine("How many points should you get for completing the checklist goal once?");
        newValue = Console.ReadLine();
        pointValue = int.Parse(newValue);
        Console.WriteLine("How many points should you get for completing the checklist goal fully?");
        newValue = Console.ReadLine();
        bonusPoints = int.Parse(newValue);
        Console.WriteLine("How many time should you do the checklist goal before completion?");
        newValue = Console.ReadLine();
        repeats = int.Parse(newValue);
    }
    public void ListChecklist(){
        Console.WriteLine($"Checklist Goal: {goalTitle}, {goalDesc}. Worth {pointValue} points upon completion and {bonusPoints} upon full completion, with {repeats} times remaining.");
    }
    public void ChecklistComplete(){
        points += pointValue;
        repeats -= 1;
        Console.WriteLine($"Congrats, you finished {goalTitle}, and got {pointValue} points!");
        if(repeats == 0){
            completed = true;
            Console.WriteLine($"Congrats, you completely finished {goalTitle}, and got an additional {bonusPoints} points!");
        }
    }
}