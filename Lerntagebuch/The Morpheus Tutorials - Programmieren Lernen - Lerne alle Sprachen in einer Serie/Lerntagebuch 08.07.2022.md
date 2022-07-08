# Lerntagebuch 08.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Call-by-Value vs Call-by-Reference
2. Lazy Evaluation
3. Function Pointer
4. Lambda Funktionen
## Call-by-Value vs Call-by-Reference [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei Call-by-Value und Call-by-Reference geht es um die unterschiedlichen Speicherverwaltungen, wenn eine Variable als Argument an eine Funktiuon übergeben wird.  

Teilweise hat man die Kontrolle darüber welche Speicherverwaltung hier gentuzt wird. Meißtens wird das aber automatisiert so das man selbst keine Kontrolle darüber hat. Es ist also von der Programmiersprache abhängig ob dies möglich ist oder nicht und bei welchen Typen das jeweilige Call-by Verfahren anwendet wird.  

Bei primitiven Datentypen (bool, char, short, int, long) wird meißtens ein Call-by-Value genutzt und bei Arrays und Listen ein Call-by-Reference, was wie gesagt unterschiedlich zwischen den Programmierpsrachen ist.  

In Java ist es bspw. genau so wie eben beschrieben, in C++ werden Zeiger verwendet, wenn man einen Call-by-Reference haben möchte und bei C# kann man ein Schlüsselwort mit angeben um ein Call-by-Reference nutzen zu können.  

Der Call-by-Value sorgt also dafür, dass eine Kopie des übergebenen Arguments erzeugt wird und diese innerhalb der Funktionen gentuzt wird ohne das die Variable die als Argument übergeben wurde verändert wird.  
`void function foo(int a){`  
    `a = 1337`  
`}`  
`int a = 42`  
`foo(a)`  
`print(a) // 42`  

Der Call-by-Reference sorgt dafür das die Speicheraddresse die auf die Variablen zeigt die als Argument übergeben wird an die Funktion übergeben wird, sodass sich die Variable innerhalb der Funktion ändert und man mit der geändert Variablen weiter arbeiten kann.  
`void function foo(List list){`  
    `list = {4, 5, 6}`  
`}`  
`List list = {1, 2, 3}`  
`foo(list)`  
`print(list) // 4, 5, 6`  

Um nun bspw. einen Integer mit einem Call-by-Reference aufrufen zu können, gibt es in manchen Programmiersprachen das Schlüsselwort `ref`.  
`void function foo(ref int a){`  
    `a = 1337`  
`}`  
`int a = 42`  
`foo(a)`  
`print(a) // 1337`  

Somit kann man im Prinzip mehrere Rückgabewerte aus einer Funktion herausbekommen.
## Lazy Evaluation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Normalerweise wird in Programmiersprachen eine Eager Evaluation durchgeführt die dafür sorgt das immer alle Bestandteile bspw. einer Liste aufgebaut und ausgeführt werden bevor man mit einem Index darauf zugreift.  
`List list = {42, 1337, sleep(3)}`  
`print(list[1])`  

Hier würde mit der Eager Evaluation die sleep-Funktion bei der Erstellung der Liste ausgeführt werden, obwohl wir gar nicht mit dem Index im weiteren Codefluss darauf zugreifen.  

Bei der Lazy Evaluation, die meißtens in funktionalen Programmiersprachen vorkommt, wird erst geschaut welches Element in der Liste gebraucht wird und dann wird nur das gewählte Element bzw. die gewählten Elemente aufgebaut und ausgeführt, was Rechenzeit spart.  
`List list = {42, 1337, sleep(3)}`  
`print(list[1])`  

Hier würde mit der Lazy Evaluation die sleep-Funktion bei der Erstellung der Liste nur ausgeführt werden, wenn wir mit dem Index im weiteren Codefluss darauf zugreifen würden. 
## Function Pointer [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Funktionen können auch wie eine Variable behandelt werden und erst später im Codefluss ausgeführt, werden in dem man Funktionszeiger nutzt.  
`function foo(){`  
    `return 1`  
`}`  
`var meineFkt = foo`  
`print(meineFkt()) // 1`  

Die Funktionszeiger können auch als Parameter übergeben werden, was häufig bei Loggern genutzt wird, bzw. wenn man seinen Output selbst schreiben möchte.  
`function foo(n, n2){`  
    `return n * n2`  
`}`  
`function bar (baz, n){`  
    `n2 = 1337`  
    `return baz(n, n2)`  
`}`  
`bar(foo,42)`  
## Lambda Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Definiert eine Funktion innerhalb von einer Zeile, was Rechenzeit erspart. Sie muss aber in eine Variable geschrieben werden, um sie nutzen zu können.  
`var fkt = (a, b) -> a * b // Java schreibweise`  
`fkt = lambda a, b: a * b // Python schreibweise`  

Nun kann sie wie eine klassische Versionverwendet werden, mann kann sich auch erst in der Argumentenliste definieren.  
`bar (lambda a, b: a * b, 42)`  
