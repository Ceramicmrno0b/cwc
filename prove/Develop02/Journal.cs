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

    }

    public string Export()
    {
        return "";
    }
}