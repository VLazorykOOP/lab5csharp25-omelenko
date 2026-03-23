using System;

namespace Lab5CSharp;

public class Republic : State
{
    public string PresidentName { get; set; }

    public Republic() : base()
    {
        PresidentName = "Unknown";
        Console.WriteLine("Constructor: Republic (default)");
    }

    public Republic(string name, string president) : base(name)
    {
        PresidentName = president;
        Console.WriteLine($"Constructor: Republic (President: {PresidentName})");
    }

    public Republic(Republic other) : base(other)
    {
        PresidentName = other.PresidentName;
        Console.WriteLine("Constructor: Republic (copy)");
    }

    ~Republic()
    {
        Console.WriteLine($"Destructor: Republic ({Name})");
    }

    public override void Show() => Console.WriteLine($"Республіка: {Name}, Президент: {PresidentName}");
}