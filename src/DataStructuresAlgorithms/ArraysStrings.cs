
public class ArraysStrings
{

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
    while (left < right)
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
  public int[] SortedSquares(int[] nums)
  {
    var squaredList = new List<int>();

    foreach (var element in nums.ToList<int>())
    {
      squaredList.Add(element * element);
    }

    squaredList.Sort();

    return squaredList.ToArray<int>();
  }

  // TODO
  // these sliding windows things i don't quite get it yet...
  public double FindMaxAverage(int[] nums, int k)
  {
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
    for (int i = k; i <= nums.Length - 1; i++)
    {
      current += nums[i];
      current -= nums[i - k];

      answer = Math.Max(answer, current / k);

      Console.WriteLine($"now I got a window average of {answer}");
    }

    return answer;
  }

  // see the exercise hints for nice explanation
  public int LongestOnes(int[] nums, int k)
  {
    int left = 0;

    // this will keep track of the condition, there can be no more than k
    // zeros in the window
    int curr = 0;

    int answer = 0;

    foreach (int right in Enumerable.Range(0, nums.Length))
    {
      if (nums[right] == 0) { curr += 1; }

      // if there are more zeros than allowed max,
      // check if the left edge is a zero,
      // if so then drop one from the counter
      // then move the left edge by one
      // 
      while (curr > k)
      {
        if (nums[left] == 0) { curr -= 1; }
        left += 1;
      }

      // return the greater of last computed length and current 
      // length (difference between right and left edge lengths but add one to account for 0-index)
      answer = Math.Max(answer, right - left + 1);
    }

    return answer;
  }

  public int[] RunningSum(int[] nums)
  {
    // TODO
    // just follow the running Sum logic shown in description

    // compute first element
    List<int> answer = new List<int>
    {
      nums[0]
    };

    for (int i = 1; i <= nums.Length - 1; i++)
    {
      answer.Add(nums[i] + answer[answer.Count - 1]);
    }

    return answer.ToArray<int>();
  }

  public int MinStartValue(int[] nums)
  {
    int start = 4;

    // psuedo-code

    // for start .. n
    //  compute running sum

    while (start <= 100)
    {
      Console.WriteLine($"start value is {start}");

      // perform the runningSum here
      List<int> runSum = new List<int>
      {
        (int)nums[0] + start
      };

      for (int i = 1; i <= nums.Length - 1; i++)
      {
        runSum.Add(nums[i] + runSum[runSum.Count - 1]);
      }

      // print runSum
      foreach(var element in runSum)
      {
        Console.WriteLine(element);
      }

      if(runSum.Contains(0))
      {
        break;
      }
      else
      {
        // do next loop
        start++;
      }
    }

    return start;
  }
}
