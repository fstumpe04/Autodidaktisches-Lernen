# Lerndokumentation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
1. Einführung und Struktur einer Klasse 
2. Law of Demeter
3. Prinzip der kleinsten Überraschung 
4. Kommentare 
5. DRY dont repeat yourself 
6. YAGNI
7. Single Responsibility
8. Open Closed
9. Liskovsches Substitutionsprinzip
## Einführung und Struktur einer Klasse [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Gut strukturierter und lesbarer Code erleichtert das Einarbeiten für einen selbst und weitere Programmierer.  

Bei Klassen gibt es ein Uncle Bobs Formating Example, welches Richtlinien für das schreiben von Klassen vorgibt.  
`class Konto{`  
    `#region Attribute`  
    `// public int (sollte man besser nur über Getter/Setter nutzen)`  
    `private int guthabenVonKonto;`  
    `private String inhaber;`  
    `#endregion`  
    `#region Statisch`  
    `public static...`  
    `private static...`  
    `#endregion`  
    `#region Konstruktor`  
    `public Konto(){}`  
    `#endregion`  
    `#region Methoden`  
    `public void ueberweisung(){}`  
    `private...`  
        `#region Getter/Setter (immer Zusammen)`  
        `public get...`  
        `public set...`  
        `#endregion`  
    `#endregion`  
`}`  
## Law of Demeter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Law of Demeter bedeutet, dass Objekte nur mit Objeketen aus ihrer unmittelbaren Umgebung kommunizieren sollen.  
<s>`int i = getObjectA().getObjectB().getSomeOtherObject().getArray()[0];`</s>  

Lange Messagechains sollten vermieden werden.  
`int i = getObjectA();`

`myMethod(param){`  
    `this.*`  
    `* = new ...`  
    `params`  
    `this.myVariable.*`  
    `// sonst nur static oder Methodenaufrufe.`
`}`  
## Prinzip der kleinsten Überraschung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um sinnvollen und logischen Code zu schreiben, sollte immer nur das in einem Konstrukt getan werden, was auch im Namen des Konstrukts steht.  

`class Immobilienvertrag{`  
    `private File vertrag;`  
    `File getVertrag(){`  
        <s>`launchNuklearMissile();`</s>  
        `return vertrag;`  
    `}`  
`}`  

`enum Date{`  
    `Montag, Dienstag, Mittwoch, ...`  
`}`  
## Kommentare [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei Kommentaren sind beide Extreme schlecht.  

Schreibt man gar keine Kommentare, können sowohl man selbst als auch andere sich schlechter im Code zurecht finden, je nachdem wie komplex die geschriebene Logik ist.  

Schreibt man zu viele Kommentare, spart man sich mehr Zeit, wenn man sich den geschriebenen Code durch liest statt den Kommentar.  

Generell sollte man folgende Dinge im Code kommentieren.  
* Methoden/Funktionen (Nutzen von summarys, Parameter- und Returnwert-Erklärungen)
* Lange und schwer zu verstehende Algorithmen
* Aufgaben in seinem Code (Nutzen von "TODO" Kommentar-Schlüsselwort)

Man sollte auch keine langen Konstrollstrukturen kommentieren. Statt dessen sollte diese ausgelagert werden.  
## DRY dont repeat yourself [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei "dont repeat yourself" (DRY) geht es darum nicht bzw. weniger zu Copy/Pasten, da die Fehleranfälligkeit dadurch sehr hoch ist.  

Stattdessen sollte man lieber den Code in eine Methode auslagern und diese mehrfach aufrufen.  
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