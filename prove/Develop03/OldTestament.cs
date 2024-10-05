public class OldTestament
{
    private List<Scripture> _books = new List<Scripture>();
    public OldTestament()
    {
        Reference reference1 = new Reference("Genesis", 1, 1, 1);
        List<Word> words1 = new List<Word>
        {
            new Word("In"),
            new Word("the"),
            new Word("beginning"),
            new Word("God"),
            new Word("created"),
            new Word("the"),
            new Word("heaven"),
            new Word("and"),
            new Word("the"),
            new Word("earth.")
        };
        Scripture scripture1 = new Scripture(reference1, words1);

        Reference reference2 = new Reference("Exodus", 14, 14, 14);
        List<Word> words2 = new List<Word>
        {
            new Word("The"),
            new Word("Lord"),
            new Word("shall"),
            new Word("fight"),
            new Word("for"),
            new Word("you"),
            new Word("and"),
            new Word("ye"),
            new Word("shall"),
            new Word("hold"),
            new Word("your"),
            new Word("peace.")
        };
        Scripture scripture2 = new Scripture(reference2, words2);

        Reference reference3 = new Reference("Psalms", 23, 1, 1);
        List<Word> words3 = new List<Word>
        {
            new Word("The"),
            new Word("Lord"),
            new Word("is"),
            new Word("my"),
            new Word("shepherd;"),
            new Word("I"),
            new Word("shall"),
            new Word("not"),
            new Word("want.")
        };
        Scripture scripture3 = new Scripture(reference3, words3);

        Reference reference4 = new Reference("Proverbs", 3, 5, 6);
        List<Word> words4 = new List<Word>
        {
            new Word("Trust"),
            new Word("in"),
            new Word("the"),
            new Word("Lord"),
            new Word("with"),
            new Word("all"),
            new Word("thine"),
            new Word("heart;"),
            new Word("and"),
            new Word("lean"),
            new Word("not"),
            new Word("unto"),
            new Word("thine"),
            new Word("own"),
            new Word("understanding.")
        };
        Scripture scripture4 = new Scripture(reference4, words4);

        _books.Add(scripture1);
        _books.Add(scripture2);
        _books.Add(scripture3);
        _books.Add(scripture4);

    }
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_books.Count);
        return _books[index];
    }
}