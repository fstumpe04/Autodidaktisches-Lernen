# Lerntagebuch 09.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Inline Funktionen
2. Code lesen
3. Klassen
4. Methoden
## Inline Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Inline Funktionen sind Omptimierungen die zwar dafür sorgen das mehr Speicherbelegt wird, aber dafür sorgt, dass das die Rechenzeit kürzer ist.  
`inline function square(double a){`  
    `return a*a;`  
`}`  
`print(square(4));`  
`// Unter der Haube: print (4*4);`  

Im Prinzip wird hier an der Stelle wo die Funktion aufgerufen werden würde, der Inhalt der Funktion direkt in den Quelltext geschrieben ohne einen Funktuionsaufruf dazwischen zu haben.  
## Code lesen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Programmieren lern man am besten, in dem man sich auch fremden Code durchliest und diesen versteht.  

Dazu kann man sich bei den meißten Programmiersprachen die Referenzen des Sourcecode der eigenen Standard-Bibliothek ansehen.  
Java: http://hg.openjdk.java.net/jdk8/jdk8/jdk/file/687fd7c7986d/src/share/classes/java/lang  
C#: https://referencesource.microsoft.com/#mscorlib  
C++: https://en.cppreference.com/w/  

Hiervon kann man sich nun einzelne Funktionen oder Methoden angucken und versuchen zu versehen,  was genau beim Aufruf passiert.
## Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ist ein Konzept, welches mehr Struktur und Ordnung in ein Projekt bringt.  

Grade für große Projekte ist dieses Konzept essentiel wichtig, da so eine bessere Übersicht gegeben ist.  

Ein Klasse ist an sich eine Blaupause von etwas was konkretisiert werden kann.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
`}`  

Hier wird als eine Klasse `Schule` definiert die einen Wert für den Namen der Schule und einen Wert für die Anzahl der Schüler bereit stellt. Die Variablen haben hier fürs erste einen von der Programmiersprache definierten Standardwert zugewiesen bekommen, der bspw- beim String `null` oder ein Leerstring (`" "`) und beim Integer eine `0` sein kann.  

Diese kann jetzt instanziiert werden, es können also jetzt mehrere Schulen konretisiert werden.  
`Schule youtube = new Schule();`  
`youtube.name = "The Morpheus Tutorials";`  
`youtube.anzahlSchueler = 13000;`  
`Schule kit = new Schule();`  
`kit.name = "KIT";`  
`kit.anzahlSchueler = 23000;`  

Wenn sich also gewiise Gemeinsamkeiten bei mehreren Konstrukten abbilden lassen können, kann man hiermit sehr gut eine Klasse erstellen die diese Wert definiert, sodass die Werte nur noch deklariert werden müssen.  
## Methoden  [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Sind an sich auch nur Funktionen, die die besondere Eigenschaft haben direkt auch Variablen in der selben Klasse zugreifen zu können, bzw. bekommen diese die selbe Klasse unter der Haube zugewiesen.  

In den meißten Programmiersprachen wird das automaitsch von der Klasse übernommen, in Python wird aber bspw. das `self`-Schlüsselwort dazu als Parameter übergeben um diese Funktion gewährleisten zu können.  

Die meißten Programmiersprachen nutzen das `this`-Schlüsselwort um die Variablen inder der Klasse nutzen zu können, man kann sie aber auch ohne das Schlüsselwort direkt nutznen.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `function neuerSchueler(){`  
        `this.anzahlSchueler++;`  
    `}`  
`}`  
`Schule youtube = new Schule();`  
`youtube.name = "The Morpheus Tutorials";`  
`youtube.anzahlSchueler = 13000;`  
`youtube.neuerSchueler(); //anzahlSchueler = 13001`  

Hier wird bspw. die Variable `anzahlSchueler` nur durch den Methodenaufruf `neuerSchueler()` um 1 erhöht.  