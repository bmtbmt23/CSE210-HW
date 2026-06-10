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
        
        Cicle store3 = new Cicle("Blue", 8);
        shapes.Add(store3);
        
        foreach (Shapes store in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            
            Console.WriteLine($"The {color} has an area of {area}. ");
            
        }
    }
}

public abstract class shape
{
    private string _color;
    {
        public Shape(string color)
        {
            _colot = color;
        }
        public string GetColor()
        {
            return color;
        }
        public abstract double GetArea();
        
    }
}