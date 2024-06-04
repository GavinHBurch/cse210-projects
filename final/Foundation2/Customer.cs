using System;

public class Customer
{
    private string _customerName;
    
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;

        _customerAddress = address;
    }

    public bool GetisFromUSA()
    {
        return _customerAddress.IsUSA() ? true : false;
    }
    
    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        string generatedAddress = _customerAddress.GetAddressString();

        return generatedAddress;
    }
}