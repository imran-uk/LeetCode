// See https://aka.ms/new-console-template for more information

var astra = new ArraysStrings();

var reversedString = astra.reverseStringList(new List<char> { 'a', 'b', 'c' });

foreach (var element in reversedString)
{
  // Console.WriteLine($"i have found letter {element}");
}

char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };
astra.reverseString(s);

// lets see if it worked...
foreach (var letter in s)
{
  // Console.WriteLine($"{letter}");
}

/*
Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
*/

int[] nums0 = new int[] { -4, -1, 0, 3, 10 };
var sortedSquares = astra.SortedSquares(nums0);

foreach (var element in sortedSquares)
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
//int k = 4;

// var maxAverage = astra.FindMaxAverage(nums, k);
// Console.WriteLine($"i got me {maxAverage}");

//int[] nums2 = new int[] { 0, 1, 1, 3, 3 };

// should be 2 according to leetcode - hmmm....
//var maxAverage = astra.FindMaxAverage(nums2, k);

//Console.WriteLine($"i got me {maxAverage}");


// LongestOnes

// Example 1s
/*
Input: nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], k = 2
Output: 6
Explanation: [1,1,1,0,0,1,1,1,1,1,1]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.
*/

int[] binaryNum = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
int kb = 2;

var longestOnes = astra.LongestOnes(binaryNum, kb);
//Console.WriteLine($"the longest one is {longestOnes}");

// ex[pected answer here is 4 but i get 3, hmmm...
int[] binaryNum2 = new int[] { 0, 0, 0, 1 };
int kb2 = 4;

var longestOnes2 = astra.LongestOnes(binaryNum2, kb2);
//Console.WriteLine($"the longest one is {longestOnes2}");

// Running Sum
/*
 *  
 *  Input: nums = [1,2,3,4]
    Output: [1,3,6,10]
    Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
*/
int[] numRun = new int[] { 1, 2, 3, 4 };
var outRun = astra.RunningSum(numRun);

foreach (var element in outRun)
{
  Console.WriteLine($"i got me {element}");
}
