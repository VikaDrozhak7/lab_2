using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public List<Virus> Children { get; set; }

    public Virus(string name, string type, double weight, int age)
    {
        Name = name;
        Type = type;
        Weight = weight;
        Age = age;
        Children = new List<Virus>();
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public object Clone()
    {
        Virus clone = (Virus)this.MemberwiseClone();
        clone.Children = new List<Virus>(this.Children.Count);
        foreach (Virus child in this.Children)
        {
            clone.Children.Add((Virus)child.Clone());
        }
        return clone;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Virus parent = new Virus("Parent", "Type1", 1.0, 10);
        Virus child1 = new Virus("Child1", "Type2", 0.5, 5);
        Virus child2 = new Virus("Child2", "Type3", 0.3, 3);

        parent.AddChild(child1);
        parent.AddChild(child2);
        Virus clone = (Virus)parent.Clone();
        Console.WriteLine($"Parent: {parent.Name}, Children: {parent.Children.Count}");
        Console.WriteLine($"Clone: {clone.Name}, Children: {clone.Children.Count}");
    }
}
