using System;

namespace Lab5CSharp;

public class Kingdom : Monarchy
{
    public string KingTitle { get; set; }

    public Kingdom() : base()
    {
        KingTitle = "Unknown";
        Console.WriteLine("Constructor: Kingdom (default)");
    }

    public Kingdom(string name, string dynasty, string title) : base(name, dynasty)
    {
        KingTitle = title;
        Console.WriteLine($"Constructor: Kingdom (Title: {KingTitle})");
    }

    public Kingdom(Kingdom other) : base(other)
    {
        KingTitle = other.KingTitle;
        Console.WriteLine("Constructor: Kingdom (copy)");
    }

    ~Kingdom()
    {
        Console.WriteLine($"Destructor: Kingdom ({Name})");
    }

    public override void Show() => Console.WriteLine($"Королівство: {Name}, Король: {KingTitle}, Династія: {Dynasty}");
}