using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GetWeatherReport()
    {
        return "The weather will be " + _weather + ".";
    }

    public string ReturnEvent()
    {
        return "Outdoor Gathering";
    }
    public string GetOutdoorGathering()
    {
        string detailed = "";

        string weatherStatement = GetWeatherReport();
        
        detailed += GetStandard() + "\n";

        detailed += "Statement of the Weather: " + weatherStatement;

        return detailed;
    }
    public string GetShortOutdoorGathering()
    {
        string shortOG = "";

        string eventType = ReturnEvent();

        shortOG += "Event Type: " + eventType + "\n";

        shortOG += GetShort();

        return shortOG;
    }
}