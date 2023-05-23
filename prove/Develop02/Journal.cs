using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Date: " + entry.Date.ToString("yyyy-MM-dd"));
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine();
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine("Date: " + entry.Date.ToString("yyyy-MM-dd"));
                writer.WriteLine("Prompt: " + entry.Prompt);
                writer.WriteLine("Response: " + entry.Response);
                writer.WriteLine();
            }
        }
    }

    public void LoadJournal(string filename)
    {
        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            Entry entry = null;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date: "))
                {
                    entry = new Entry();
                    entry.Date = DateTime.ParseExact(line.Replace("Date: ", ""), "yyyy-MM-dd", null);
                }
                else if (line.StartsWith("Prompt: "))
                {
                    entry.Prompt = line.Replace("Prompt: ", "");
                }
                else if (line.StartsWith("Response: "))
                {
                    entry.Response = line.Replace("Response: ", "");
                    entries.Add(entry);
                }
            }
        }
    }
}
