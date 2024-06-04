using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string ReturnEvent()
    {
        return "Reception";
    }

    public string GetReception()
    {
        string detailed = GetStandard() + "\n";

        detailed += "RSVP: " + _email;

        return detailed;
    }
    public string GetShortReception()
    {
        string shortReception = "";

        string eventType = ReturnEvent();

        shortReception += "Event Type: " + eventType + "\n";

        shortReception += GetShort();

        return shortReception;
    }
}