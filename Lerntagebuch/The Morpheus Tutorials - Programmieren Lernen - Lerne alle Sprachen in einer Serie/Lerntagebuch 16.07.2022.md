# Lerntagebuch 16.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Super
2. Interfaces
3. Mehrfachvererbung und das Diamantenproblem
4. Abstrakte Klassen
## Super [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `Super`-Schlüsselwort nutzt man um in einer Unterklasse eine Methode der Oberklasse aufzurufen.  
`class Schule{`  
    `public int anzahlSchueler;`  
    `public void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
    `}`  
`}`  
`class Gymnasium : Schule{`  
    `public bool hasGrundschulabschluss;`  
    `public new void neuerSchueler(){`  
        `if (hasGrundschulabschluss){`  
            `anzahlSchueler += 1;`  
        `}`  
    `}`  
    `public void vipKid(){`  
        `Super.neuerSchueler();`  
    `}`  
`}`  
Hier wird bspw. das `Super`-Schlüsselwort benutzt um klar zu stellen das man die Methode der Oberklasse verwenden möchte und nicht die überschrieben Methode in der selben Klasse.  
## Interfaces [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `interface`-Schlüsselwort wird dazu verwendet ein Interface zu definieren, wovon ähnlich wie bei einer normalen Klasse vererbt werden kann.  

Ein Interface selbst kann nicht instanziiert werden und es werden nur Methodenköpfe innerhalb eines Interfaces definiert die, wenn man sie an eine Klasse vererbt zwingend definiert werden müssen.  
`interface BildungInstanz{`  
    `public function void neuerSchueler();`  
`}`  
`class Schule implements BildungsInstanz{`  
    `public function void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
    `}`  
`}`  

Nun kann man wie bei den Klassen ein Array vom Typ des definierten interfaces erstellen und durch alle Klassen die von dem Interface geerbt haben iteriieren.  
`BildungsInstanz[] meinArray = {Schule, Gymnasium};`  
`for (BildungsInstanz i in meinArray){`  
    `i.neuerSchuler();`  
`}`  

Meißtens wird nur eine Methode pro Interface definiert damit es übersichtlicher ist.
## Mehrfachvererbung und das Diamantenproblem [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei der Mehrfachvererbung kann das Problem entstehen, das wenn man eine Methode aufruft die mehrfach in der Vererbungshierarchie definiert wurde nicht klar ist, welche nun ausgeführt werden soll.  

Deswegen verbieten viele Programmiersprachen die Mehrfachvererbung, man kann also in diesen nur von einer Klasse erben. Es ist aber möglich von mehreren Interfaces zu erben, da hier ja keine Definition gegeben ist.  
`interface IBildung{`  
    `public int AnzahlSchueler { get; set; }`  
    `void neuerSchueler();`  
`}`  
`class Schule : IBildung{`  
    `public int AnzahlSchueler { get; set; }`  
    `public void neuerSchueler(){`  
        `AnzahlSchueler += 1;`  
    `}`  
`}`  
`class Gymnasium : Schule, IBildung{`  
    `public int AnzahlSchueler { get; set; }`  
    `public void neuerSchueler(){`  
        `AnzahlSchueler += 1;`  
    `}`  
`}`  

In C++ ist dies einfach erlaubt und würde zum Absturz des Programms führen wenn die mehrfach definierte Methode aufgerufen wird.  

In Python ist die Reihenfolge der aufgeschrieben Klassen relevant, da immer die erste Methode mit dem gewählten Name für den Methodenaufruf ausgewählt wird die in den jeweiligen Klassen gefunden werden und dann wird der Methodenaufruf durchgeführt, ohne dass in den weiteren Klassen danach geschaut wird.  
## Abstrakte Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `abstract`-Schlüsselwort sorgt bei einer Klasse dafür das man wie bei den Interfaces nicht nicht von ihnen instanziieren kann und man Methodenköpfe definieren kann. Man kann aber auch ganz normal wie bei Klassen auch Variablen und vollständige Methoden definieren. Hierbei ist gar keine Mehrfachvererbung möglich.  
`abstract class Schule{`  
    `public int anzahlSchueler;`  
    `public void neuerSchueler();`  
    `public void zeigeAnzahlSchueler(){`  
        `print($"Die aktuelle Schueleranzahl lautet {AnzahlSchueler}");`  
    `}`  
`}`  
`class Gymnasium : Schule{`  
    `public int anzahlSchueler;`  
    `public void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
    `}`  
`}`  