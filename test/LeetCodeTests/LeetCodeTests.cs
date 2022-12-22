using NUnit.Framework;
using LeetCode;

namespace LeetCodeTests;

public class LeetCodeUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    // TODO
    // include several test cases ehre
    [Test]
    public void MaxCustomerWeathTest()
    {
        // Arrange
        var maxWealthExpected = 42;

        // given this input
        var customerAccounts = new int[][] { 
            new int[] {1, 2, 3}, 
            new int[] {6, 3, 2}, 
            new int[] {7, 8, 9} 
        };
        var sol = new LeetCodeSolution();

        // Act
        var maxValueCalculated = sol.MaximumWealth(customerAccounts);

        // Assert
        // Assert.Equals(maxValueCalculated, maxWealthExpected);
    }
}