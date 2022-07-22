# Lerntagebuch 22.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Generische Funktionen
## Generische Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Generische Funktionen nutzt man so wie normal Methoden, man hier aber den Typ `<T>` sowohl als Parameter als auch als Rückgabewert verwenden.  
`function T[] sort<T> (T[] elements){`  
    `//...`  
`}`  
`String[] meinArray = {"verstecke champion", ";", "seit 1958"};`  
`meinArray = sort(meinArray);`  

Hier muss kein Variablentyp übergeben werden, da dieser unter der Haube mit übergeben wird.  