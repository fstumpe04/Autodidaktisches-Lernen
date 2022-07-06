// continue
string[] meinStringArray = {"42", "dieses", "tut", "ist", "geil"};
foreach (string element in meinStringArray)
{
    System.Console.WriteLine("abc");
    continue;
    System.Console.WriteLine(element);
}
/*
abc
abc
abc
abc
abc
*/
foreach (string element in meinStringArray)
{
    if (element == "42")
    {
        continue;   
    }
    System.Console.WriteLine(element);
}
/*
dieses
tut
ist
geil
*/

// break
meinStringArray = new string[] {"dieses", "tut", "ist", "geil","42", "hi", "wtf", "ist"};
foreach (string element in meinStringArray)
{ 
    System.Console.WriteLine(element);
    if (element == "geil")
    {
        break;   
    }
}
/*
dieses
tut
ist
geil
*/