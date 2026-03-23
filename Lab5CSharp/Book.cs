using System;

namespace Lab5CSharp;

public class Book : Edition
{
    public string Author { get; set; }
    public int Year { get; set; }

    public Book() : base()
    {
        Author = "Unknown";
        Year = 0;
        Console.WriteLine("Constructor: Book (default)");
    }

    public Book(string title, string author, int year) : base(title)
    {
        Author = author;
        Year = year;
        Console.WriteLine($"Constructor: Book (Author: {Author}, Year: {Year})");
    }

    public Book(Book other) : base(other)
    {
        Author = other.Author;
        Year = other.Year;
        Console.WriteLine("Constructor: Book (copy)");
    }

    ~Book()
    {
        Console.WriteLine($"Destructor: Book ({Title})");
    }

    public override void Show()
    {
        Console.WriteLine($"Книга: '{Title}', Автор: {Author}, Рік: {Year}");
    }

    public override bool IsMatch(string searchTitle)
    {
        return Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase);
    }
}