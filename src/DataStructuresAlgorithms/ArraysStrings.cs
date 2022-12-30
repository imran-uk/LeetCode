
public class ArraysStrings {

  public List<char> reverseStringList(List<char> input)
  {
    input.Reverse();

    return input;
  }

  // time/space complexity
  // time = O(n)
  // space = O(n) or O(1)
  public void reverseString(char[] input)
  {
    // modify input in-place
    // use opposite-direction two-pointers approach somehow
    // see https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4501/
    int left = 0;
    int right = input.Length - 1;

    // TODO: is this equivalent? it's what i put first in my mind...
    // would be good tow rite own test cases for this shiz :D
    // while(left != right)
    while(left < right)
    {
      var temp = input[left];
      input[left] = input[right];
      input[right] = temp;

      left++;
      right--;
    }
  }

  // TODO: the exercise says there might be another approach that 
  // takes O(n)
  // the main thing i can think of is to sort the input array first 
  // because the squared number will still be in the same order
  public int[] SortedSquares(int[] nums) {
    var squaredList = new List<int>();

    foreach(var element in nums.ToList<int>())
    {
      squaredList.Add(element * element);
    }

    squaredList.Sort();

    return squaredList.ToArray<int>();
  }

  // TODO
  // these sliding windows things i don't quite get it yet...
  public double FindMaxAverage(int[] nums, int k) {
      // define the base-case

      double current = 0;
      double answer = 0;

      // since window size is fixed in this case, we can
      // build the first window
      for (int i = 0; i < k; i++) 
      {
        current += nums[i];
      }

      // compute average of first window (base case?)
      answer = current / k;

      Console.WriteLine($"initial window average {answer}");

      // slide window along by one...
      for (int i = k; i <= nums.Length-1; i++)
      {
        current += nums[i];
        current -= nums[i - k];
        
        answer = Math.Max(answer, current / k);

        Console.WriteLine($"now I got a window average of {answer}");
      }

      return answer;
  }
}