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

    foreach((int hashKey, int hashValue) in myHashMap)
    {
      Console.WriteLine(
        $"got me these keys/values from ma'hash yo: {hashKey} => {hashValue}");
    }
  }
}
