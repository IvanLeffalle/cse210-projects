public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _author;
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt {_promptText}\n{_entryText}\nAuthor:{_author}\n");
    }
}
