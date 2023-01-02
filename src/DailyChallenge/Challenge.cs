namespace DailyChallenge;

internal class Challenge
{

  // https://leetcode.com/problems/detect-capital/
  public bool DetectCapitalUse(string word)
  {
    if (string.IsNullOrEmpty(word))
    {
      return false;
    }

    // USA = true
    // Foobar = true
    // FOobar = false
    // foobar = true
    // barfoO = false

    // psuedo-code

    bool firstCharIsCapital = false;
    int wordLength = word.Length;
    int loopVar = 0;
    int capitalCount = 0;

    List<char> chars= word.ToList<char>();

    foreach (char c in chars)
    {
      if(char.IsUpper(c))
      {
        capitalCount += 1;

        if(loopVar == 0)
        {
          firstCharIsCapital = true;
        }
      }

      loopVar += 1;
    }

    if(wordLength == capitalCount)
    {
      return true;
    }
    else if(capitalCount == 1 && firstCharIsCapital)
    {
      return true;
    }
    else if(capitalCount == 0)
    {
      return true;
    }
    else
    { 
      return false; 
    }
  }
}
