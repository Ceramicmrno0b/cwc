public class Entry
{
    public string response;
    public string prompt;
    

    public Entry(string response, string prompt)
    {
        string date = DateTime.Today.ToString("yyyy-MM-dd");
        Console.WriteLine(prompt);
        this.response = Console.ReadLine();
        this.prompt = prompt;
    }
}