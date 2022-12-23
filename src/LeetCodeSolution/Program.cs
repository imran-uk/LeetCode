// See https://aka.ms/new-console-template for more information
using LeetCodeSolution;

var sol = new LeetCode();

// max Wealth of customer accounts
int[][] customerAccounts = new int[][] { 
    new int[] {1, 2, 3}, 
    new int[] {6, 3, 2} 
};
// int maxWealth = sol.MaximumWealth(customerAccounts);
// Console.WriteLine($"Maximum customer wealth is: {maxWealth}");

// ok, now for FizzBuzz
List<string> fizzBuzzOutput1 = sol.FizzBuzz(3);
foreach(string element in fizzBuzzOutput1)
{
    // Console.WriteLine($"The FizzBuzz output: {element}");
}

List<string> fizzBuzzOutput2 = sol.FizzBuzz(5);
foreach(string element in fizzBuzzOutput2)
{
    // Console.WriteLine($"The FizzBuzz output: {element}");
}

List<string> fizzBuzzOutput3 = sol.FizzBuzz(15);
foreach(string element in fizzBuzzOutput3)
{
    // Console.WriteLine($"The FizzBuzz output: {element}");
}

// okay now steps to zero
int stepsToZero = sol.NumberOfSteps(7);
Console.WriteLine($"Steps to zero with 7: {stepsToZero}");