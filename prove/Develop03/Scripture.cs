using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> words;

    public Scripture(string referenceString, string text)
    {
        reference = new Reference(referenceString);
        this.text = text;
        words = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = words.FindAll(word => !word.IsHidden);

        if (visibleWords.Count == 0)
        {
            Console.WriteLine("All words are already hidden.");
            return;
        }

        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();

        Display(); // Display the modified scripture with hidden word
    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }

        return true;
    }

    public void Display()
    {
        Console.Clear(); // Clear the console
        Console.WriteLine(reference.ToString() + ":");
        foreach (Word word in words)
        {
            if (word.IsHidden)
            {
                Console.Write(new string('_', word.Text.Length) + " ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }
}
