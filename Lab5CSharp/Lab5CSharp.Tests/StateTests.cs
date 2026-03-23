using Xunit;
using Lab5CSharp;

namespace Lab5CSharp.Tests;

public class StateTests
{
    [Fact]
    public void Kingdom_Constructor_SetsAllProperties()
    {
        // Arrange
        string name = "Denmark";
        string dynasty = "Glücksburg";
        string title = "King";

        // Act
        var kingdom = new Kingdom(name, dynasty, title);

        // Assert
        Assert.Equal(name, kingdom.Name);
        Assert.Equal(dynasty, kingdom.Dynasty);
        Assert.Equal(title, kingdom.KingTitle);
    }

    [Fact]
    public void Republic_CopyConstructor_CopiesData()
    {
        // Arrange
        var original = new Republic("France", "Emmanuel Macron");

        // Act
        var copy = new Republic(original);

        // Assert
        Assert.Equal(original.Name, copy.Name);
        Assert.Equal(original.PresidentName, copy.PresidentName);
    }
}