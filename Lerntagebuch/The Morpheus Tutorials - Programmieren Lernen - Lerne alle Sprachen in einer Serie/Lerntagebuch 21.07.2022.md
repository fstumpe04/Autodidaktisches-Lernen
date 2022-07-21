# Lerntagebuch 21.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Generics
## Generics [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Generische Klassen haben Typparameter `<T>`, die immer einen anderen Typ haben können, bspw. den Typ `int`.  

Man kann also je nach dem welchen Typparameter man übergibt, unterschiedlich mit dem Objekt innerhalb der Klasse arbeiten, was bspw. einzelne Sortierverfahren ausßerhalb der Klasse erspart.  
`class Container<T>{`  
`}`  
`Container<int> tonne = Container<int>();`  

Bei Java müsste man bei der Initalisierung einer generischen Klasse die Wrapperklassen verwenden um das Typargument zu übergeben, da die Standarddatentypen hier nicht funktionieren, hier muss also bspw. die Wrapperklasse `Integer` verwendet werden.  

Man könnte hiermit also auch eigene generische Datenstrukturen erstellen, die bspw. innerhalb der Klasse die Struktur sortiert statt sie über einen extra Methodenaufruf sortieren zu müssen.  

`class Container<T>{`  
    `T[] meinArray;`  
    `private function void sortierung(){`  
        `if (T[0].equals.(T[1])){`  
            `///...`  
        `}`  
    `}`  
`}`  