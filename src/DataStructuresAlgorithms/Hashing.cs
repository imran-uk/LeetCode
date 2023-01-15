namespace DataStructuresAlgorithms;

internal class Hashing
{
  // a simple hash map example
  public void SimpleHashMap()
  {
    var myHashMap = new Dictionary<int, int>
    {
      { 4, 83 }
    };

    Console.WriteLine("yo, my hashMap gets this val for key 4: {0}",
      myHashMap.GetValueOrDefault(4));

    Console.WriteLine("can i get value 4 from my hash? {0}",
      myHashMap.TryGetValue(4, out _));
    Console.WriteLine("can i get value 854 from my hash? {0}",
      myHashMap.TryGetValue(854, out _));

    myHashMap.Add(8, 327);
    myHashMap.Add(45, 82523);

    foreach ((int hashKey, int hashValue) in myHashMap)
    {
      Console.WriteLine(
        $"got me these keys/values from ma'hash yo: {hashKey} => {hashValue}");
    }
  }

  // repeated character
  public char RepeatedChar(string s)
  {
    // TODO is there a Set type in C# like in Python?
    var repeatSet = new Dictionary<char, int>();

    foreach (var element in s)
    {
      if (repeatSet.TryGetValue(element, out _))
      {
        return element;
      }

      repeatSet.Add(element, 1);
    }

    return ' ';
  }


  // use HashSet in C#
  public char RepeatedCharSet(string s)
  {
    var repeatSet = new HashSet<char>();

    foreach (var element in s)
    {
      if (repeatSet.Contains(element)) { return element; }

      repeatSet.Add(element);
    }

    return ' ';
  }

  // another example computing different stuff
  public List<int> findNumbers(int[] nums)
  {
    List<int> result = new List<int>();
    HashSet<int> numSet = new HashSet<int>();

    // build hashset using the nums
    foreach (var element in nums)
    {
      numSet.Add(element);
    }

    // now we can iterate over nums and check nuMSet to simplify
    // lookup to O(1) rather than an inner loop, making it O(n*n)
    foreach (var element in nums)
    {
      if (!numSet.Contains(element + 1)
        && !numSet.Contains(element - 1)) { result.Add(element); }
    }

    return result;
  }

  public bool CheckIfPangram(string sentence)
  {
    HashSet<char> charHash = new HashSet<char>();

    foreach (var element in sentence)
    {
      charHash.Add(element);
    }

    // TODO
    // in C# is there an easier way to create the alphabet?
    // in perl it's a..z
    foreach (char element in "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower())
    {
      if (!charHash.Contains(element)) { return false; }
    }

    return true;
  }

  public int? MissingNumber(int[] nums)
  {
    int? missingNumber = null;

    HashSet<int> numSet = new HashSet<int>();

    foreach (var element in nums)
    {
      numSet.Add(element);
    }

    for (int i = 0; i <= nums.Length; i++)
    {
      if (!numSet.Contains(i))
      {
        missingNumber = i;
      }
    }

    return missingNumber;
  }

  public int CountElements(int[] arr)
  {
    int plusOneCount = 0;

    HashSet<int> plusOneSet = new HashSet<int>();

    // loop through array and 
    // put each value in a HashSet
    foreach (var element in arr)
    {
      plusOneSet.Add(element);
    }

    for (int i = 0; i < arr.Length; i++)
    {
      Console.WriteLine($"{arr[i]} and {arr[i] + 1}");

      if (plusOneSet.Contains(arr[i] + 1))
      {
        plusOneCount += 1;
      }
    }

    return plusOneCount;
  }
}
