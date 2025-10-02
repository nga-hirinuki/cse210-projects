using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split words by space, not underscore
        string[] words = text.Split(' '); 

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Get all visible words
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                visibleWords.Add(word);
            }
        }

        // If all words are hidden, finish 
        if (visibleWords.Count == 0)
            return;

        // Hide words randomly every time you press enter
        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0) // Stop if all visible words are hidden
                break;

            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText; 
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
           return _words.All(word => word.IsHidden());
        }
        return true; // All words are hidden
    }
}