using System;

namespace Lab5CSharp;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть завдання:");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                RunTask1and2();
                break;
            case "2":
                RunTask1and2();
                break;
            case "3":
                RunTask3();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("\n--- Програма завершена ---");
    }

    static void RunTask1and2()
    {
        Console.WriteLine("\n--- Тестування ієрархії State ---");

        Console.WriteLine("\nСтворення Republic:");
        Republic rep = new Republic("Україна", "Володимир Зеленський");
        rep.Show();

        Console.WriteLine("\nСтворення Kingdom:");
        Kingdom king = new Kingdom("Велика Британія", "Віндзори", "Чарльз III");
        king.Show();
    }

    static void RunTask3()
    {
        Console.WriteLine("\n--- Тестування ієрархії Edition ---");

        Book myBook = new Book("Кобзар", "Тарас Шевченко", 1840);
        myBook.Show();

        string search = "Кобзар";
        Console.WriteLine($"Пошук '{search}': {myBook.IsMatch(search)}");
    }

    public struct TeamStruct
    {
        public string Name;
        public string City;
        public int PlayersCount;
        public int Points;

        public TeamStruct(string name, string city, int players, int points)
        {
            Name = name;
            City = city;
            PlayersCount = players;
            Points = points;
        }

        public override string ToString() => $"[Struct] {Name} ({City}), Очки: {Points}";
    }

    public void RunTask4Struct()
    {
        List<TeamStruct> teams = new List<TeamStruct>
        {
            new TeamStruct("Динамо", "Київ", 25, 50),
            new TeamStruct("Шахтар", "Донецьк", 24, 48),
            new TeamStruct("Ворскла", "Полтава", 22, 30)
        };

        int minPoints = 35;
        teams.RemoveAll(t => t.Points < minPoints);

        teams.Insert(0, new TeamStruct("Зоря", "Луганськ", 23, 40));
        teams.Insert(0, new TeamStruct("Дніпро-1", "Дніпро", 22, 45));

        Console.WriteLine($"Результат (Struct) при minPoints = {minPoints}:");
        teams.ForEach(t => Console.WriteLine(t));
    }

    public static void RunTask4Tuple()
    {
        // (Name, City, PlayersCount, Points)
        List<(string Name, string City, int Players, int Points)> teams = new List<(string, string, int, int)>
            {
                ("Динамо", "Київ", 25, 50),
                ("Шахтар", "Донецьк", 24, 48),
                ("Ворскла", "Полтава", 22, 30)
            };

        int minPoints = 35;
        teams.RemoveAll(t => t.Points < minPoints);

        teams.Insert(0, ("Зоря", "Луганськ", 23, 40));
        teams.Insert(0, ("Дніпро-1", "Дніпро", 22, 45));

        Console.WriteLine($"Результат (Tuple) при minPoints = {minPoints}:");
        foreach (var t in teams)
            Console.WriteLine($"[Tuple] {t.Name} ({t.City}), Очки: {t.Points}");
    }

    public record TeamRecord(string Name, string City, int PlayersCount, int Points);

    public void RunTask4Record()
    {
        List<TeamRecord> teams = new List<TeamRecord>
        {
            new TeamRecord("Динамо", "Київ", 25, 50),
            new TeamRecord("Шахтар", "Донецьк", 24, 48),
            new TeamRecord("Ворскла", "Полтава", 22, 30)
        };

        int minPoints = 35;
        teams.RemoveAll(t => t.Points < minPoints);

        teams.Insert(0, new TeamRecord("Зоря", "Луганськ", 23, 40));
        teams.Insert(0, new TeamRecord("Дніпро-1", "Дніпро", 22, 45));

        Console.WriteLine($"Результат (Record) при minPoints = {minPoints}:");
        foreach (var t in teams)
            Console.WriteLine($"[Record] {t.Name} ({t.City}), Очки: {t.Points}");
    }
}