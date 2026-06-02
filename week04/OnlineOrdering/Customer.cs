using System;

public class Customer
{
    private string _name;
   private Address _address;
   
    public Customer(string name, string Address)
    {
        _name = name;
        _address = Address;
    }
    public string Getname()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address;
    }
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
   
}