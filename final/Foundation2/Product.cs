using System;

public class Product
{
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public string GetProductID()
    {
        return _id;
    }

    public double GetProductTotalCost()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}