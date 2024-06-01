using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Carr. Tenayuca Chalmits 828", "Zona Escolar", "07230 Ciudad de Mexico", "Mexico");

        Customer customer1 = new Customer("Jose Smith", address1);

        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Paper Mario: The thousand-Year Door", "A001", 57.95, 1);

        Product p1002 = new Product("Nitendo Switch with Neon Blue and Neon Red Joy Con with MightySkins Voucher - Limited Bundle", "A002", 279.99, 1);

        Product p1003 = new Product("Nitendo Switch Pro Controller", "A003", 58.65, 2);

        productsList1.Add(p1001);

        productsList1.Add(p1002);

        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");

        order1.DisplayResults();

        Console.WriteLine();

        Address address2 = new Address("100 main st", "Bentonville", "AR 72712", "USA");

        Customer customer2 = new Customer("Stacy Forrest", address2);

        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("XB1 Xbox Series S", "B0003", 299.00, 1);

        Product p2002 = new Product("Rig 400 HX Xbox Gaming Headset for Xbox", "B002", 39.88, 2);

        Product p2003 = new Product("PowerA Wired Controller for Xbox Series X/S - Black", "B003", 25.00, 2);

        productsList2.Add(p2001);

        productsList2.Add(p2002);

        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");

        order2.DisplayResults();

        Console.WriteLine();

        Address address3 = new Address("290 E 700 N", "American Fork", "UT 84003", "USA");

        Customer customer3 = new Customer("Moroni Nephi", address3);

        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Sony PlayStation 5 (PS5) Disc Console Slim", "C001", 449.00, 1);

        Product p3002 = new Product("Horizon: Forbidden West Special Edition", "C002", 129.99, 1);

        Product p3003 = new Product("Sony PS5 DualSense Wireless Controller - Midnight Black", "C003", 69.00, 2);

        productsList3.Add(p3001);

        productsList3.Add(p3002);

        productsList3.Add(p3003);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");

        order3.DisplayResults();

        Console.WriteLine();
    }
}