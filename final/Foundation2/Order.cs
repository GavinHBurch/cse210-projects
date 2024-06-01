using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;

        _customer = customer;
    }

    public double CalculateShipping() 
    {
        double shippingCost = _customer.GetisFromUSA() ? 5 : 35;

        return shippingCost;
    }

    public double CalculateTotalPrice()
    {
        double totalprice = 0;

        foreach (Product p in _products) 
        {
            double price = p.CalculatePrice();

            totalprice += price;
        }

        double shippingCost = CalculateShipping();

        totalprice += shippingCost;

        return totalprice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product p in _products) 
        {
            packingLabel += p.GetProductName() + " - " + p.GetProductID() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";

        shippingLabel += _customer.GetCustomerName() + "\n" + _customer.GetCustomerAddress();

        return shippingLabel;
    }

    public string CalculateTotalOrder()
    {
        string totalCost = "\nProducts:\n";

        double totalPrice = CalculateTotalPrice();

        foreach (Product p in _products) 
        {
            totalCost += p.GetProductName() + " (" + p.GetProductID() + ") - " + "$" + p.GetProductTotalCost() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
        }
        
        totalCost += "Shipping Cost: $" + CalculateShipping() + "\n";

        totalCost += "Total: $" + CalculateTotalPrice();
        
        return totalCost;
    }

    public void DisplayResults()
    {
        string packingLabel = GetPackingLabel();

        string shippingLabel = GetShippingLabel();

        string totalOrder = CalculateTotalOrder();

        Console.WriteLine(packingLabel);

        Console.WriteLine(shippingLabel);

        Console.WriteLine(totalOrder);
    }
}