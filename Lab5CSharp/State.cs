using System;

namespace Lab5CSharp;

public abstract class State
{
    public string Name { get; set; }

    public State()
    {
        Name = "Unknown State";
        Console.WriteLine("Constructor: State (default)");
    }

    public State(string name)
    {
        Name = name;
        Console.WriteLine($"Constructor: State (Name: {Name})");
    }

    public State(State other)
    {
        Name = other.Name;
        Console.WriteLine("Constructor: State (copy)");
    }

    ~State()
    {
        Console.WriteLine($"Destructor: State ({Name})");
    }

    public abstract void Show();
}