using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double total = 0;
    }
    
    foreach (Product product in _products)
    {
        total += product.GetTotalCost();
    }
    
    if (_customer.LivesInUSA())
    {
        += 5;
    }
    else
    {
        total += 35;
    }
    return total;
}
public string GetPackingLabel()
{
    foreach (product product in _products)
    {
        label += product.GetPackingInfo();
    }
}
public string GetshippingLabel()
{
    return $"Shipping Label:" {_customer.Getname()} {_customer.GetAddress().GetFullAddress()};
}