public class Journal
{
    DateTime theCurrentTime = DateTime.Now;
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Console.WriteLine("Please enter your name: ");
        string author = Console.ReadLine();
        PromptGenerator generator = new PromptGenerator();
        string randomPrompt = generator.GetRandomPrompt();
        Console.WriteLine($"{randomPrompt}");
        string entry = Console.ReadLine();
        string dateText = theCurrentTime.ToShortDateString();
        Entry newEntry = new Entry
        {
            _promptText = randomPrompt,
            _entryText = entry,
            _date = dateText,
            _author = author
        };
        _entries.Add(newEntry);

    }
    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }

    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine();
            }
        }
    }
    public void LoadFromFile(string File)
    {
        string[] lines = System.IO.File.ReadAllLines(File);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}