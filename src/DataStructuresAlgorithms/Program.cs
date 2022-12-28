// See https://aka.ms/new-console-template for more information

var astra = new ArraysStrings();

var reversedString = astra.reverseStringList(new List<char>{ 'a', 'b', 'c' });

foreach(var element in reversedString)
{
  // Console.WriteLine($"i have found letter {element}");
}

char[] s = new char[] { 'h','e','l','l','o' };
astra.reverseString(s);
