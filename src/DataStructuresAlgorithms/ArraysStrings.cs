

public class ArraysStrings {

  public List<char> reverseStringList(List<char> input)
  {
    input.Reverse();

    return input;
  }

  public void reverseString(char[] input)
  {
    foreach(var letter in input.Reverse())
    {
      Console.WriteLine($"{letter}");
    }
  }
}