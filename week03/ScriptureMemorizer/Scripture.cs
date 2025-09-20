using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                visibleIndexes.Add(i);
        }
        Random rand = new Random();
        for (int i = 0; i < count && visibleIndexes.Count > 0; i++)
        {
            int randPosition = rand.Next(visibleIndexes.Count); 
            int wordIndex = visibleIndexes[randPosition];      
            _words[wordIndex].Hide();                      

            visibleIndexes.RemoveAt(randPosition);           
        }
    }
    // Enhancement method. Reveals hidden words.
    public void RevealRandomWords(int count)
    {
        List<int> hiddenIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden())
                hiddenIndexes.Add(i);
        }

        Random rand = new Random();
        for (int i = 0; i < count && hiddenIndexes.Count > 0; i++)
        {
            int randPosition = rand.Next(hiddenIndexes.Count);
            int wordIndex = hiddenIndexes[randPosition];
            _words[wordIndex].Show(); 

            hiddenIndexes.RemoveAt(randPosition);         
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = "";

        for (int i = 0; i < _words.Count; i++)
        {
            wordsText += _words[i].GetDisplayText() + " ";
        }
        wordsText.TrimEnd();

        return referenceText + " " + wordsText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }
        return true; 
    }
}