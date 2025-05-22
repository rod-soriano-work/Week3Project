using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var rand = new Random();
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int idx = rand.Next(visibleWords.Count);
            visibleWords[idx].Hide();
            visibleWords.RemoveAt(idx);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", Words));
        Console.WriteLine();
    }
}
