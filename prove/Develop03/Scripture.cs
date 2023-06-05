using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> hiddenWords;

    public Scripture(string referenceString, string text)
    {
        reference = new Reference(referenceString);
        this.text = text;
        hiddenWords = new List<Word>();
    }

    public void HideRandomWord()
    {
        string[] words = text.Split(' ');
        Random random = new Random();
        int index = random.Next(0, words.Length);

        Word hiddenWord = new Word(words[index]);
        hiddenWords.Add(hiddenWord);

        words[index] = new string('_', hiddenWord.Value.Length);

        text = string.Join(" ", words);
        Display(); // Display the modified scripture with hidden word
    }

    public bool AreAllWordsHidden()
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            if (!hiddenWords.Exists(hiddenWord => hiddenWord.Value == word))
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
        Console.WriteLine(text);
    }
}
