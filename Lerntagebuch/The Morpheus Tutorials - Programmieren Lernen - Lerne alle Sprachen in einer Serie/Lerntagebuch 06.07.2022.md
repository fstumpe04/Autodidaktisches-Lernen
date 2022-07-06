# Lerntagebuch 04.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. for-Schleifen
2. foreach-Schleifen
3. break und continue
4. Funktionen
## for-Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ist eine Alternative zu while-Schleifen und wird eher genutzt wenn man etwas durchzählen möchte.  
`for (int i = 0; i < 42; i++)`  
`{`  
    `// Schleifenrumpf`  
`}`  

Hier würde man von 0-41 in Einzelschritten druchiterieren.  

Dies Form von Schleifen werden auch häufig für Arrays oder Listen verwendet.  
`int[] meinArray = {42, 1337, 42, 42, 42};`  
`for (int i = 0; i < meinArray.Length; i++)`  
`{`  
    `System.Console.WriteLine(meinArray[i]);`  
`}`  

Hier würde jedes Element aus dem Array hintereinander auf der Konsole ausgegeben werden.  

Die Variable `int i;` kann nur in dem for-Schleifenrumpf verwendet werden, da diese nur dort bekannt ist. Nach den Schleifendruchläufen wird der belegte Speicher hierfür also frei gegeben.
## foreach-Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Wird dazu verwendet um bspw. jedes Element eines Arrays zu durchlaufen.  
`int[] meinIntArray = {42, 1337, 42, 42, 42};`  
`foreach (int element in meinIntArray)`  
`{`  
    `System.Console.WriteLine(element);`  
`}`  

Hier wird jede Zahl in dem zuvor definierten Array auf der Konsole ausgegeben.  

Für String-Arrays ist diese Form von Schleifen auch sehr praktisch.  
`string[] meinStringArray = {"42", "dieses", "tut", "ist", "geil"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine(element);`  
`}`  

Diese Form von Schleifen kommt häufig in schwachtypisierten Programmiersprachen vor.  
## break und continue [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
`break` und  `continue` sind Schlüsselwörter die in Schleifendruchläufen dazu verwendet werden, diese zu unterbrechen.  

Bei dem Schlüsselwort `continue` wird der derzeitige Schleifendurchlauf an der Stelle unterbrochen und es wird direkt zum nöchsten Schleifendurchlauf gesprungen.  
`string[] meinStringArray = {"42", "dieses", "tut", "ist", "geil"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine("abc");`  
    `continue;`  
    `System.Console.WriteLine(element);`  
`}`  

Hier würde also 5 mal `abc` auf der Nosole ausgegeben werden, da `print(element);` hinter dem `continue` steht.  

Dies funktioniert in jeglicher Form von Schleifen.  

Nun kan mauch IF-Verzweigungen mit dem `continue` verwenden um dies nur unter einer Bedingung ausführen zu lassen.  
`foreach (string element in meinStringArray)`  
`{`  
    `if (element == "42")`  
    `{`  
        `continue;`  
    `}`  
    `System.Console.WriteLine(element);`  
`}`  

Hiuer wird also nur `diesestutistgeil` auf der Konsole ausgegeben.  

Wenn man generell das `continue` am Ende der Schleife setzt, verschwendet man nur unnötige Rechenzeit, da man ncihts überspringt.  

Das Schlüsselwort `break`sorgt auch dafür das der Schleifendurchlauf unterbrochen wird, nur werden hier bei alle weiteren Schleifendurchläufe die noch kommen sollten nich mehr ausgeführt.  
`string meinStringArray = new string[] {"dieses", "tut", "ist", "geil","42", "hi", "wtf", "ist"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine(element);`  
    `if (element == "geil")`  
    `{`  
        `break;`  
    `}`  
`}`  

Hier wird nur `diesestutistgeil` ausgegeben und es mach Sinn das `break` vor dem Schleifenende auszuführen, da man hier noch etwas unterbricht.  
## Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Benötigt man um Code auslagern zu können den man mehrfach ausführen will.  

Nennt man meißtens foo o. bar o. baz. und man definiert sie mit dem Schlüsselwort def o. function davor.  
`function foo()`  
`{`  
    `System.Console.WriteLine("***STARTE DAS PROGRAMM***");`  
    `System.Console.WriteLine("_________________________");`  
`}`  

Diese Funktion kann man nun über den Funktionsnamen und den runden Klammern aufrufen und z.B. in einer Schleife mehrfach ausführen.  
`for (int i = 0; i < 10; i++){`
    `foo();`
`}`

Diese Art kennt man auch aus der Mathematik.  
`f(x) = 2*x`  
