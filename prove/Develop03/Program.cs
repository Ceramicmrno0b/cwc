using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.DisplayScripture();
        scripture.BlankOutWords();
        Console.WriteLine("Congrats, you've finished this scripture!");
    }
}