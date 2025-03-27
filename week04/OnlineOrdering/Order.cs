using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate the total cost of the order (including shipping)
    public decimal CalculateTotalCost()
    {
        decimal totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.CalculateTotalCost();
        }

        // Discount if applicable
        totalProductCost = ApplyDiscount(totalProductCost);

        // Shipping cost based on customer location
        decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }

    // Apply discounts based on certain conditions
    public decimal ApplyDiscount(decimal totalCost)
    {
        // Apply a 10% discount if the total cost is greater than $1000
        if (totalCost > 1000)
        {
            Console.WriteLine("Applying 10% discount for orders over $1000.");
            return totalCost * 0.9m; 
        }

        // Apply a 5% discount if the customer is from Springfield
        if (_customer.CustomerAddress.City.ToLower() == "springfield")
        {
            Console.WriteLine("Applying 5% discount for customers from Springfield.");
            return totalCost * 0.95m; 
        }

        // No discount 
        return totalCost;
    }

    // Packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }

    // Shipping label
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.Name}\n";
        shippingLabel += _customer.CustomerAddress.GetFullAddress();
        return shippingLabel;
    }
}
