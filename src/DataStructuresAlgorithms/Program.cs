// See https://aka.ms/new-console-template for more information

var astra = new ArraysStrings();

var reversedString = astra.reverseStringList(new List<char>{ 'a', 'b', 'c' });

foreach(var element in reversedString)
{
  // Console.WriteLine($"i have found letter {element}");
}

char[] s = new char[] { 'h','e','l','l','o' };
astra.reverseString(s);

// lets see if it worked...
foreach(var letter in s)
{
  // Console.WriteLine($"{letter}");
}

/*
Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
*/

int[] nums = new int[] { -4,-1,0,3,10 };
var sortedSquares = astra.SortedSquares(nums);

foreach(var element in sortedSquares)
{
  Console.WriteLine($"i got me {element}");
}