using System;

public class Entry
{
  public string Prompt { get; set; }

  public string Response { get; set; }

  public DateTime Date { get; set; }

  public Entry(string prompt, string response)
  {
    Prompt = prompt;

    Response = response;

    Date = DateTime.Now;
  }
// method to display 
  public override string ToString()
  {
    return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
  }
}