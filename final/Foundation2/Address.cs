using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;

        _city = city;

        _stateProvince = state;

        _country = country;
    }

    public bool IsUSA()
    {
        return _country == "USA" ? true : false;
    }

    public string GetAddressString()
    {
        string address = _street + ", " + _city + "\n" + _stateProvince + ", " + _country;
        
        return address;
    }
}