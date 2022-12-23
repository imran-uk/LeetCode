using NUnit.Framework;
using LeetCodeSolution;

namespace LeetCodeUnitTest;

public class LeetCodeUnitTest
{
    private LeetCode sol = default!;

    [SetUp]
    public void Setup()
    {
        sol = new LeetCode();
    }

    // TODO
    // include several test cases ehre
    [Test]
    public void MaxCustomerWeathTest()
    {
        // Arrange
        var maxWealthExpected = 24;

        // given this input
        var customerAccounts = new int[][] { 
            new int[] {1, 2, 3}, 
            new int[] {6, 3, 2}, 
            new int[] {7, 8, 9} 
        };

        // Act
        var maxValueCalculated = sol.MaximumWealth(customerAccounts);

        // Assert
        Assert.AreEqual(maxWealthExpected, maxValueCalculated);
    }
}
