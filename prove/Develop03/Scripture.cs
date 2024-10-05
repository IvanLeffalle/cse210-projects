public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsToHide = numberToHide;
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string displayText = referenceText + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

