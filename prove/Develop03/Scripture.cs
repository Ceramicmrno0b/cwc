using System;
using System.Collections.Generic;

class Scripture
{
    private string reference = "1 Nephi 8:11: ";
    private List<string> scripture = new List<string> {"And ", "it ", "came ", "to ", "pass ", "that ", "I ", "did ", "go ", "forth ", "and ", "partake ", "of ", "the ", "fruit ", "thereof; ", "and ", "I ", "beheld ", "that ", "it ", "was ", "most ", "sweet, ", "above ", "all ", "that ", "I ", "ever ", "before ", "tasted. ", "Yea, ", "and ", "I ", "beheld ", "that ", "the ", "fruit ", "thereof ", "was ", "white, ", "to ", "exceed ", "all ", "the ", "whiteness ", "that ", "I ", "had ", "ever ", "seen."};
    private List<string> blanked = new List<string> {"___ ", "__ ", "____ ", "__ ", "____ ", "____ ", "_ ", "___ ", "__ ", "_____ ", "__ ", "_______ ", "__ ", "___ ", "_____ ", "_______; ", "___ ", "_ ", "______ ", "____ ", "__ ", "___ ", "____ ", "_____, ", "_____ ", "___ ", "____ ", "_ ", "____ ", "______ ", "______. ", "___, ", "___ ", "_ ", "______ ", "____ ", "___ ", "_____ ", "_______ ", "___ ", "_____, ", "__ ", "______ ", "___ ", "___ ", "_________ ", "____ ", "_ ", "___ ", "____ ", "____."};
    
    public void DisplayScripture()
    {
        Console.WriteLine(reference);
        Console.WriteLine(string.Join("", scripture));
        string empty = Console.ReadLine();
        //Console.Clear();
    }

    public void BlankOutWords()
    {
        List<int> openNumbers = new List<int>();
        for (int i=0; i<=scripture.Count-1; i++)
        {
            openNumbers.Add(i);
        }
        Random rnd = new Random();
        for (int i = 0; i < 17; i++)
        {
            for (int c = 0; c < 3; c++)
            {
                int item  = rnd.Next(0, openNumbers.Count);
                scripture[openNumbers[item]] = blanked[openNumbers[item]];
                openNumbers.RemoveAt(item);
            }
            Console.WriteLine(reference);
            Console.WriteLine(string.Join("", scripture));
            string empty = Console.ReadLine();
            Console.Clear();
        }
    }
}