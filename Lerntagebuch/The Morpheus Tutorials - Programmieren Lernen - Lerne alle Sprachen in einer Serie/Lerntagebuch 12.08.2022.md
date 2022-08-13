# Lerntagebuch 12.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Map
## Map [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Map-Funktion führt eine Funktion auf jedem Element einer Struktur aus.  
`l = [1,2,3,4,5,6]`  
`function foo(x){`  
    `return x + 2;`  
`}`  
`l = map(l,foo);`  
`function map (list, f ){`  
    `result = []`  
    `foreach i in list{`  
        `result.append(f(i));`  
    `}`  
`}`  