public class NewTestament
{
    private List<Scripture> _books = new List<Scripture>();
    public NewTestament()
    {
        Reference reference1 = new Reference("Matthew", 5, 5, 5);
        List<Word> words1 = new List<Word>
        {
            new Word("Blessed"),
            new Word("are"),
            new Word("the"),
            new Word("meek"),
            new Word("for"),
            new Word("they"),
            new Word("shall"),
            new Word("inherit"),
            new Word("the"),
            new Word("earth.")
        };
        Scripture scripture1 = new Scripture(reference1, words1);

        Reference reference2 = new Reference("John", 3, 16, 16);
        List<Word> words2 = new List<Word>
        {
            new Word("For"),
            new Word("God"),
            new Word("so"),
            new Word("loved"),
            new Word("the"),
            new Word("world"),
            new Word("that"),
            new Word("He"),
            new Word("gave"),
            new Word("His"),
            new Word("only"),
            new Word("begotten"),
            new Word("Son"),
            new Word("that"),
            new Word("whosoever"),
            new Word("believeth"),
            new Word("in"),
            new Word("Him"),
            new Word("should"),
            new Word("not"),
            new Word("perish"),
            new Word("but"),
            new Word("have"),
            new Word("everlasting"),
            new Word("life.")
        };
        Scripture scripture2 = new Scripture(reference2, words2);

        Reference reference3 = new Reference("Luke", 6, 31, 31);
        List<Word> words3 = new List<Word>
        {
            new Word("And"),
            new Word("as"),
            new Word("ye"),
            new Word("would"),
            new Word("that"),
            new Word("men"),
            new Word("should"),
            new Word("do"),
            new Word("to"),
            new Word("you,"),
            new Word("do"),
            new Word("ye"),
            new Word("also"),
            new Word("to"),
            new Word("them"),
            new Word("likewise.")
        };
        Scripture scripture3 = new Scripture(reference3, words3);

        Reference reference4 = new Reference("Romans", 8, 28, 28);
        List<Word> words4 = new List<Word>
        {
            new Word("And"),
            new Word("we"),
            new Word("know"),
            new Word("that"),
            new Word("all"),
            new Word("things"),
            new Word("work"),
            new Word("together"),
            new Word("for"),
            new Word("good"),
            new Word("to"),
            new Word("them"),
            new Word("that"),
            new Word("love"),
            new Word("God.")
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