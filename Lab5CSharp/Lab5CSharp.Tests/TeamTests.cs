using Lab5CSharp;
using System.Collections.Generic;
using Xunit;
using static Lab5CSharp.Program;

namespace Lab5CSharp.Tests;

public class TeamTests
{
    [Fact]
    public void TeamProcessing_ShouldFilterAndAddElements()
    {
        // Arrange
        var teams = new List<TeamRecord>
        {
            new TeamRecord("Team1", "City1", 10, 10), // Має бути видалено (очки < 35)
            new TeamRecord("Team2", "City2", 10, 50)
        };
        int minPoints = 35;

        // Act
        teams.RemoveAll(t => t.Points < minPoints);
        teams.Insert(0, new TeamRecord("New1", "City3", 10, 40));
        teams.Insert(0, new TeamRecord("New2", "City4", 10, 45));

        // Assert
        Assert.Equal(3, teams.Count);
        Assert.DoesNotContain(teams, t => t.Name == "Team1");
        Assert.Equal("New2", teams[0].Name); // Перевірка додавання на початок
    }
}