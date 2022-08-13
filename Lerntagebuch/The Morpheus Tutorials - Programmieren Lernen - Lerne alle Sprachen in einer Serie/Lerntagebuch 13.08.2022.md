# Lerntagebuch 13.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Zip
2. Unzip
3. Filter
4. Reduce
## Zip [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Zip-Funktion dient zum zusammenfügen von mehreren Datenstrukturen zu einer. Das Ergebnis ist dann eine Liste aus Tupeln.  
`l = [1, 2, 3]`  
`l2 = [3, 4, 5]`  
`l3 = zip(l, l2) //l3 = [(1, 2), (2, 4), (3, 5)]`
## Unzip [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Unzip-Funktion ist der Gegensatz von der Zip-Funktion und erzeugt aus der Liste von Tupeln  wieder eine Liste mit je einem Element mit einem primitiven Datentypen.  
`l3 = [(1, 2), (2, 4), (3, 5)]`  
`l4 = unzip(l3)`  
`l4 = [(1, 2, 3), (3, 4, 5)]`
## Filter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Durch die Filter-Funktion kann man eine Datenstruktur mit einer bestimmten Funktion filtern um bspw. nur noch Primzahlen in einer Liste stehen zu haben.  
`l = [1, 2, 3, 4, 5, 6]`  
`l2 = filter(foo, l) //l2 = [2, 4, 6]`  
`function filter (f, list){`  
    `result = []`  
    `for i in list{`  
        `if f(i){`  
            `result.append(i)`  
        `}`  
    `}`  
`}`  
`function foo(x){`  
    `return x % 2 == 0`  
`}`
## Reduce [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit der Reduce-Funktion wird jedes Element einer Datenstruktur auf ein Element angeglichen, was sich durch eine Funktion ergibt.  
`l = [1, 2, 3, 4, 5, 6]`  
`x = reduce(l, foo)`  
`function reduce(l, foo){`  
    `magie = list[0]`  
    `for (int i = 1;i < list.length();i++){`  
        `magie = f(magie, list[i])`  
    `}`  
`}`  
`function foo (a, b){`  
    `if (a > b){`  
        `return a;`  
    `}`  
    `return b;`  
`}`  