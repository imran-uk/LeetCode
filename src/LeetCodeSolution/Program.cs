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
// Console.WriteLine($"Steps to zero with 7: {stepsToZero}");

// middle of the list task
var listNodeOf3 = new ListNode(1, new ListNode(2, new ListNode(3)));
var listNodeOf2 = new ListNode(1, new ListNode(2));
var listNodeOf5 = new ListNode(1, new ListNode(2, 
    new ListNode(3, 
        new ListNode(4, 
            new ListNode(5)))));


var middleOfList2 = sol.MiddleNode(listNodeOf2);

while(middleOfList2 is not null)
{
    var nodeVal = middleOfList2.val;
    Console.WriteLine($"The nodeList value is: {nodeVal}");
    middleOfList2 = middleOfList2.next;
}

var middleOfList3 = sol.MiddleNode(listNodeOf3);

while(middleOfList3 is not null)
{
    var nodeVal = middleOfList3.val;
    Console.WriteLine($"The nodeList value is: {nodeVal}");
    middleOfList3 = middleOfList3.next;
}

var middleOfList5 = sol.MiddleNode(listNodeOf5);

while(middleOfList5 is not null)
{
    var nodeVal = middleOfList5.val;
    Console.WriteLine($"The nodeList value is: {nodeVal}");
    middleOfList5 = middleOfList5.next;
}
