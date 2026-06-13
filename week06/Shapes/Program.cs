using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("This program computes the areas of different shapes cut out of pieces of paper.");
        
        List<Shape> shapes = new List<Shape>();
        
        Square store1 = new Square("Green", 4);
        shapes.Add(store1);
        
        Rectangle store2 = new Rectangle("Pink", 4, 6);
        shapes.Add(store2);
        
        Circle store3 = new Circle("Blue", 8);
        shapes.Add(store3);
        
        foreach (Shape store in shapes)
        {
            string color = store.GetColor();
            double area = store.GetArea();
            
            Console.WriteLine($"The {color} has an area of {area}. ");
            
        }
    }
}

public abstract class Shape
{
    private string _color;
    
        public Shape(string color)
        {
            _color = color;
        }
        public string GetColor()
        {
            return _color;
        }
        public abstract double GetArea();
}
