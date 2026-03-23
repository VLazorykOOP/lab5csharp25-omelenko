using Xunit;
using Lab5CSharp;

namespace Lab5CSharp.Tests;

public class EditionTests
{
    [Theory]
    [InlineData("Kobzar", "kobzar", true)]
    [InlineData("Kobzar", "Bible", false)]
    [InlineData("Kobzar", "KOBZAR", true)]
    public void Book_IsMatch_ShouldBeCaseInsensitive(string title, string search, bool expected)
    {
        // Arrange
        var book = new Book(title, "Shevchenko", 1840);

        // Act
        bool result = book.IsMatch(search);

        // Assert
        Assert.Equal(expected, result);
    }
}