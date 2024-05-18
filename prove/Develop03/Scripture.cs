// Class to represent a scripture
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string referenceText, string scriptureText)
    {
        _reference = new Reference(referenceText);

        // Split the scripture text into words
        string[] wordsArray = scriptureText.Split(' ');

        // Initialize the list of words
        _words = new List<Word>();
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide a random number of words
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    // Get the display text of the scripture
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }
}
