using System;

public class Product
{
    private string _name;
    private string _ProductId;
    private double _price;
    private int _quantity;
   
    public Product( string name, string ProductId, double price, int quantity)
    {
        _name = name;
        _ProductId = ProductId;
        _price = price;
        _quantity = quantity;
    }
   
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"Product: {_name}, ID: {_ProductId}";
    }
   
}