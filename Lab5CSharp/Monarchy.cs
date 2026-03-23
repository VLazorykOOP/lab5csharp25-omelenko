using System;

namespace Lab5CSharp;

public class Monarchy : State
{
    public string Dynasty { get; set; }

    public Monarchy() : base()
    {
        Dynasty = "Unknown";
        Console.WriteLine("Constructor: Monarchy (default)");
    }

    public Monarchy(string name, string dynasty) : base(name)
    {
        Dynasty = dynasty;
        Console.WriteLine($"Constructor: Monarchy (Dynasty: {Dynasty})");
    }

    public Monarchy(Monarchy other) : base(other)
    {
        Dynasty = other.Dynasty;
        Console.WriteLine("Constructor: Monarchy (copy)");
    }

    ~Monarchy()
    {
        Console.WriteLine($"Destructor: Monarchy ({Name})");
    }

    public override void Show() => Console.WriteLine($"Монархія: {Name}, Династія: {Dynasty}");
}