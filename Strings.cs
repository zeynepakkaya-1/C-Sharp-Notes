string string1 = "Zeynep";

Console.WriteLine(string1.Length); // 6

Console.WriteLine(string1.EndsWith("p"));
Console.WriteLine(string1.StartsWith("Z"));

Console.WriteLine(string1.IndexOf("y")); // 2
Console.WriteLine(string1.IndexOf("X")); // -1
Console.WriteLine(string1.LastIndexOf("e")); // 4

Console.WriteLine(string1.Insert(0, "Hi ")); // Hi Zeynep

Console.WriteLine(string1.Substring(3)); // nep

Console.WriteLine(string1.ToLower());
Console.WriteLine(string1.ToUpper());

Console.WriteLine(string1.Replace("e", "*")); // Z*yn*p

Console.WriteLine(string1.Remove(3)); // Zey
Console.WriteLine(string1.Remove(3, 2)); // Zeyp

var clone = string1.Clone();
Console.WriteLine(clone); // Zeynep