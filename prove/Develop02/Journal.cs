using System.Reflection.Metadata;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string importString)
    {

    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine(entries);
    }

    public string Export()
    {
        string finalExport = "";
        foreach (var entry in entries)
        {
            finalExport += $"{entry}";
        }
        return finalExport;
    }
}