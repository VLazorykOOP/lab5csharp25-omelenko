using System;

namespace Lab5CSharp;

public abstract class Edition
{
    public string Title { get; set; }

    public Edition()
    {
        Title = "Unknown";
        Console.WriteLine("Constructor: Edition (default)");
    }

    public Edition(string title)
    {
        Title = title;
        Console.WriteLine($"Constructor: Edition (Title: {Title})");
    }

    public Edition(Edition other)
    {
        Title = other.Title;
        Console.WriteLine("Constructor: Edition (copy)");
    }

    ~Edition()
    {
        Console.WriteLine($"Destructor: Edition ({Title})");
    }

    public abstract void Show();
    public abstract bool IsMatch(string searchTitle);
}