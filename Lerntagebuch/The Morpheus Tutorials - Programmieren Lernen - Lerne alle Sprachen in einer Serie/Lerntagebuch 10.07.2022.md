# Lerntagebuch 10.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Konstruktoren
2. Zugriffsmodifikatoren
3. Getter/Setter
4. Static - Klassenvariablen
5. Vererbung
## Konstruktoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ein Konstruktor ist die erste Methode die in einer Klasse aufgerufen wird und setzt standardmäßig alle Klassenvariablen auf einen Standardwert und belegt somit den dementsprechenden Speicher, was je nach Programmiersprache unterschiedlich ist. Man also eigentlich immer einen Standardkonstruktor der unter der Haube ausgeführt wird.  

Aufgerufen wird dieser Konstruktor bei der Erzeugung einer Instanz mit dem `new`-Schlüsselwort.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(){`  
        `name = "MeineSchule";`  
        `anzahlSchueler = 500;`  
    `}`  
`}`  
`Schule schule = new Schule();`  

Nun kann man auch einen eigenen Konstruktor schreiben, in dem man sogar eine Parameterliste einbauen kann. Wenn man das tut verfällt der Standardkonstruktor unter der Haube.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(string name, int anzahlSchueler){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule kit = new Schule("KIT", 23000);`  

Hier kann jetzt nur noch eine Instanz erzeugt werden, wenn die Parameterliste gefüllt ist.  

Das `this`-Schlüsselwort ist hier nun relevanter, da man hiermit sicherstellen kann, dass die Variable in der Klasse gemeint ist und nicht das Argument welches an die Funktion übergeben wird.  

Falls man jetzt Standardwerte für die Parameter des Kosntruktor setzten möchte, lann man von der Klasse auch wieder Instanzen erzeugen, die keinen Parameter übergeben bekommen.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(string name = "", int anzahlSchueler = 0){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule schule = new Schule();`
## Zugriffsmodifikatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Durch Zuggriffsmodifikatoren kann man den Zugriff auf eine Klasse steuern, wenn man bspw. verhindern möchte, dass eine Wert verändert wird.  

Die grundlegenenden Zugriffsmodifikatoren die es in so ziemlicher jeder Programmierpsrache gibt,  sind `public` und `private`. `public` ist meißtens der standardmäßige Zugriffsmodifikator und sorgt dafür das jeglicher Zugriff auf die Klassenvariable, Methode oder Klasse an sich erlaubt ist, während `private` dafür sorgt das nur ein Zugriff innerhalb der Klasse erlaubt ist.  
`public class Schule{`  
    `public string name;`  
    `private int anzahlSchueler;`  
    `public Schule(string name = "", int anzahlSchueler = 0){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule kit = new Schule("KIT", 23000);`  

Hier kann man zwar die Variable `int anzahlSchueler` beim Initialisieren durch den Konstruktor setzen, man kann aber durch das `private`-Schlüsselwort nicht mehr darauf zugreifen.  
## Getter/Setter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um nun `private` Variablen nur auslesbar oder nur schreibbar zu machen, gibt es sogenannte Getter- und Setter-Methoden, die dies druch einen Methodenaufruf ermöglichen.  
`public class Schule{`  
    `private int anzahlSchueler;`  
    `public Schule(int anzahlSchueler){`  
        `this.anzahlSchueler = anzahlSchueler;`  
    `}`  
    `public int getAnzahlSchueler(){`  
        `return anzahlSchueler;`  
    `}`  
`}`  
`Schule schule = new Schule(23000);`  
`int anzahlSchueler = schule.getAnzahlSchueler();`  

Hier kann man also nur noch die Variable auslesen und nicht mehr schreiben.  
`public class Schule{`  
    `private int anzahlSchueler;`  
    `public Schule(){`  
        `this.anzahlSchueler = 0;`  
    `}`  
    `public int getAnzahlSchueler(){`  
        `return anzahlSchueler;`  
    `}`  
    `public void setAnzahlSchueler(int anzahlSchueler){`  
        `if (anzahlSchueler >= 0){`
        `this.anzahlSchueler = anzahlSchueler;`  
        `}`
    `}`  
`}`  

Hier kann man durch den Setter dafür sorgen, dass die Anzahl der Schüler nur auf einen positiven Wert gesetzt wird.  

Wenn man also im Getter nur die Variable zurück gibt und im Setter nur die Variable setzt, kann man besser einfach die Variable auf `public` setzen.  
## Static - Klassenvariablen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Falls man einen Wert setzen möchte der für alle Instanzen einer Klasse gleich sien soll, benutzt man dazu `static`-Klassenvariablen.  
`public class Schule{`  
    `public static string gesetzesgrundlage = "SchG";`  
`}`  

Diese `static`-Klassenvariable ist nun für alle Instanzen gleich und sie belegt auch nur einmalig den Speicher.  
`Schule kit = new Schule();`  
`Schule youtube = new Schule();`  
`// kit.gesetzesgrundlage == youtube.gesetzesgrundlage`  

Je nach Programmierpsrache kann man diesen Wert jetzt ändern, dieser wird aber dann für alle Instanzen geändert.  
`// Schule.gesetzesgrundlage = "abc" o. kit.gesetzesgrundlage = "abc"`  

Man kann hier auch Getter- und Setter-Methoden benutzen nur müssen die auch `static` sein und man kann hier keine Variablen nutzen die nicht `static` sind.  

Da das `this`-Schlüsselwort auch nur für nicht statische Variablen funktioniert, nutzt man hier statt dessen den Klassennamen.  
`public class Schule{`  
    `private static string gesetzesgrundlage = "SchG";`  
    `public static string getGesetzesgrundlage(){`  
        `return Schule.gesetzesgrundlage;`  
    `}`  
`}`  
## Vererbung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Eine Vererbung ist eine Verbindung zwischen Klassen.  

Generell solte man beim Programmieren nie Copy-Pasten müssen, da man immer besser Funktion/Klassen erstellt oder von anderen erbt, um den selben Code mehrfach aufzurufen.  

Wenn man nun seine Klasse spezifizieren will und die selben Variablen und Methoden aus einer Klasse benötigt, kann man die Vererbung nutzen.  
`class Schule{`  
    `public string name;`  
    `public int anzahlSchueler;`  
`}`  
`class Gymnasium extends Schule{`  
`}`  

Hier kann man jetzt eine Instanz von der Klasse `Gymnasium` erzeugen und die gleichen Variablen aus der Klasse `Schule` nutzen, da diese quasi in die Klasse `Gymnasium` kopiert werden.  
`Gymnasium g = new Gymnasium();`  
`g.name = "MeinGymmi";`  
`g.anzahlSchueler = 400;`  

Der Klasse `Gymnasium` kann man jetzt auch eigene passende Variablen und Methoden hinzufügen und nutzen, diese haben dann natürlich nichts mehr mit der Klasse `Schule` zu tun.  
`class Schule{`  
    `public string name;`  
    `public int anzahlSchueler;`  
`}`  
`class Gymnasium extends Schule{`  
    `public string abschluss = "Abitur";`  
`}`  
`Gymnasium g = new Gymnasium();`  
`g.name = "MeinGymmi";`  
`g.anzahlSchueler = 400;`  
`string abschluss = g.abschluss;`
