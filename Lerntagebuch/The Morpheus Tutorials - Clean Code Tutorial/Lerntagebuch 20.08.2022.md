# Lerntagebuch 20.08.2022
1. YAGNI
2. Single Responsibility
3. Open Closed
4. Liskovsches Substitutionsprinzip
## YAGNI [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
You aren't gonna need it (YAGNI, z. dt. Du wirst es nicht brauchen.) bedeutet, dass man keinen Code schreiben sollte der nicht genutzt wird.  

Wichtig ist also erst die Grundfunktion eines Programms zu entwicklen und dann Features einzubauen.  
## Single Responsibility [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Single Responsibility ist eins von 5 SOLID-Prinzipien und besagt, das ein Klasse immer nur eine große Funktionalität erfüllen soll.  
`class myConnector{`  
    `socket connect(..)...`  
    `void terminateConnection(param Socket)`  
    <s>`void send()`</s>  
`}`  
`class Communicator{`  
    `void send()`  
    `... receive()`  
`}`
## Open Closed [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Open-Closed ist eins von 5 SOLID-Prinzipien und besagt, dass Porgramme so programmiert werden sollen, dass sie erweiterbar sind und gleichzeitig nicht verändert werden sollten.  
`class Shape{`  
    `... draw()`  
`}`  

`class Program{`  
`for Shape s in ShapeListe{`  
    <s>`switch(typeof(s)){`  
        `case Kreis: s.draw()`</s>  
        `s.draw()`  
    `}`  
`}`  
## Liskovsches Substitutionsprinzip [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das Liskovsche Substitutionsprinzip ist eins von 5 SOLID-Prinzipien und besagt, dass Methoden einer Klasse immer auch Objekte einer abgeleiteten Klasse nutzen können muss.  
`class Quadrat` <s>`extends Rechteck`</s>`{`  
    `// height == width ! IMMER`  
    `float width;`  
    `// height < width;`  
    `setWidth(float w){`  
        `width = w;`  
        `// width = w; height = w;`  
    `}`  
`}`  
`class Rechteck extends Quadrat{`  
    `float width;`  
    `float height;`  
`}`  