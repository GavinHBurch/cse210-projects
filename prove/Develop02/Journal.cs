using System;

using System.Collections.Generic;

using System.IO;


//making journal list

public class Journal
{
  private List<Entry> entries = new List<Entry>();

//Adding Entry

  public void AddEntry(string prompt, string response)
  {
    Entry entry = new Entry(prompt, response);

    entries.Add(entry);
  }

//Displaying Entries

  public void DisplayEntries()
  {
    foreach (Entry entry in entries)
    {
      Console.WriteLine(entry);
    }
  }

  public int EntriesCount()
  {
      return entries.Count;
  }

//Saving Files

  public void SaveToFile(string fileName)
  {
    using (StreamWriter writer = new StreamWriter(fileName))
    {
      foreach (Entry entry in entries)
      {
        writer.WriteLine($"Date: {entry.Date}");

        writer.WriteLine($"Prompt: {entry.Prompt}");

        writer.WriteLine($"Response: {entry.Response}\n");
      }
    }
  }

//Loading Files

  public void LoadFromFile(string fileName)
  {
    entries.Clear();

    try
    {
      using (StreamReader reader = new StreamReader(fileName))
      {
        string line;

        string currentPrompt = null;

        string currentResponse = null;

        DateTime currentDate = DateTime.MinValue;

        while ((line = reader.ReadLine()) != null)
        {
          if (line.StartsWith("Date: "))
          {
            currentDate = DateTime.Parse(line.Substring("Date: ".Length));
          }
          else if (line.StartsWith("Prompt: "))
          {
            currentPrompt = line.Substring("Prompt: ".Length);
          }
          else if (line.StartsWith("Response: "))
          {
            currentResponse = line.Substring("Response: ".Length);

            entries.Add(new Entry(currentPrompt, currentResponse)

            {
              Date = currentDate,

              Prompt = currentPrompt,

              Response = currentResponse
            });
          }
        }
      }
    }
    catch (Exception)
    {
      
    }
  }
}