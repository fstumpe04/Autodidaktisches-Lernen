using System.Collections.Generic;

// Liste
List<int> a = new List<int>();
a.Add(42);
foreach (var item in a)
{
    System.Console.WriteLine(item);   
}
System.Console.WriteLine($"Die Länge der Liste lautet {a.Count()}");

LinkedList<int> b = new LinkedList<int>();
b.AddFirst(42);
System.Console.WriteLine($"Die Länge der Linked Liste lautet {a.Count()}");