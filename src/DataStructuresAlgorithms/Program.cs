// See https://aka.ms/new-console-template for more information

using DataStructuresAlgorithms;

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
  //Console.WriteLine($"i got me {element}");
}

// Minimum Start Value
/*
Input: nums = [-3, 2, -3, 4, 2]
Output: 5
*/
int[] numMin = new int[] { -3, 2, -3, 4, 2 };
var outMin = astra.MinStartValue(numMin);
//Console.WriteLine($"got me min start value of {outMin}");

var outMinAnon = astra.MinStartValueAnon(numMin);
//Console.WriteLine($"Anon / got me min start value of {outMinAnon}");

// efficient way to build a string
string oldString = "moonshine";
string newStringFromBuilder = astra.BuildString(oldString);
//Console.WriteLine($"the string builder gave me dis: {newStringFromBuilder}");

string newStringFromNormal = astra.NormalStringBuilder(oldString);
//Console.WriteLine($"the normal string method gave me dat: {newStringFromNormal}");

// HASHING

var hashi = new Hashing();

hashi.SimpleHashMap();

string repeater = "abcdefe";
//var repeatedChar = hashi.RepeatedChar(repeater);
var repeatedChar = hashi.RepeatedCharSet(repeater);
Console.WriteLine(
  $"i am checking if there is a repeated character in " +
  $"{repeater} and it is: {repeatedChar}");

// find target numbers in an array
int[] magicNumbers = new int[] { 3, 4, 1, 5, 6, 7, 9 };
// should return { 1, 9 }
var resultMagic = hashi.findNumbers(magicNumbers);

foreach (var element in resultMagic)
{
  Console.WriteLine($"got me this magic number {element}");
}

string sentence1 = "I am a crazy frog.";
var panagramCheck1 = hashi.CheckIfPangram(sentence1);
Console.WriteLine($"is /{sentence1}/ a panagram? {panagramCheck1}");

// should be true
string sentence2 = "thequickbrownfoxjumpsoverthelazydog";
var panagramCheck2 = hashi.CheckIfPangram(sentence2);
Console.WriteLine($"is /{sentence2}/ a panagram? {panagramCheck2}");

// find missing number
int[] numFind = new int[] { 0, 1, 3 };
var theMissingNumber = hashi.MissingNumber(numFind);
Console.WriteLine($"yo, i found the missing number and it is: {theMissingNumber}");


int[] numFind2 = new int[] { 0, 1 };
var theMissingNumber2 = hashi.MissingNumber(numFind2);
Console.WriteLine(
  $"yo, i found the missing number and it is: {theMissingNumber2}");

int[] numFind3 = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
var theMissingNumber3 = hashi.MissingNumber(numFind3);
Console.WriteLine(
  $"yo, i found the missing number and it is: {theMissingNumber3}");

// count elements
var numCounting = new int[] { 1, 2, 3 };
var theNumberCount = hashi.CountElements(numCounting);
Console.WriteLine($"the count of x+1 is: {theNumberCount}");


// find winners
/*
 * Input: matches = [[1,3],[2,3],[3,6],[5,6],[5,7],[4,5],
 * [4,8],[4,9],[10,4],[10,9]]
Output: [[1,2,10],[4,5,7,8]]
Explanation:
Players 1, 2, and 10 have not lost any matches.
Players 4, 5, 7, and 8 each have lost one match.
Players 3, 6, and 9 each have lost two matches.
Thus, answer[0] = [1,2,10] and answer[1] = [4,5,7,8].
*/

var matches = new int[][]
{
  new int[] { 1, 3 },
  new int[] { 2, 3 },
  new int[] { 3, 6 },
  new int[] { 5, 6 },
  new int[] { 5, 7 },
  new int[] { 4, 5 },
  new int[] { 4, 8 },
  new int[] { 4, 9 },
  new int[] { 10, 4 },
  new int[] { 10, 9 }
};

var winners = hashi.FindWinners(matches);

foreach(var playerGroup in winners)
{
  foreach(var element in playerGroup)
  {
    Console.WriteLine(element);
  }
}
