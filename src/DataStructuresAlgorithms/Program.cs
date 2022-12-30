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

int[] nums0 = new int[] { -4,-1,0,3,10 };
var sortedSquares = astra.SortedSquares(nums0);

foreach(var element in sortedSquares)
{
  // Console.WriteLine($"i got me {element}");
}


// Sliding windows shiz

/*
Input: nums = [1, 12, -5, -6, 50, 3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
*/
int[] nums = new int[] { 1, 12, -5, -6, 50, 3 };
int k = 4;

// var maxAverage = astra.FindMaxAverage(nums, k);
// Console.WriteLine($"i got me {maxAverage}");

int[] nums2 = new int[] { 0, 1, 1, 3, 3 };

// should be 2 according to leetcode - hmmm....
var maxAverage = astra.FindMaxAverage(nums2, k);

Console.WriteLine($"i got me {maxAverage}");