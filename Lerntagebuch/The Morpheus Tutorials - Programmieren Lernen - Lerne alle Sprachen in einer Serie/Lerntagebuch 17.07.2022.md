# Lerntagebuch 17.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Der Zugriffsmodifikator protected
2. Statische innere Klassen
3. Innere Klassen
4. Anonyme innere Klassen
## Der Zugriffsmodifikator protected [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `protected`-Schlüsselwort kann an den selben stellen wie die Schlüsselwörter `public` und `private` eingesetzt werden. Es sorgt dafür, dass die damit modifizierten Variblen und Methoden nur innerhalb der Klassenhierarchie aufgerufen werden können, also nur innerhalb der selben Klasse oder innerhalb der vererbten Unterklassen.  
## Statische innere Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die statischen inneren Klassen können dazu verwendet werden, selbst definierte Objekte an eine Klasse zu binden, also man kann nur Objekte dieser Klasse erzuegen wenn die äußere Klasse bereits instanziiert wurde.  
`class Schule{`  
    `// innere Klasse`  
    `public static class Schueler{`  
        `int alter;`  
        `string name;`  
    `}`  
`}`  
`Schule.Schueler hans = Shcule.new Schueler();`  

Hier kann man nun auch innerhalb der äußeren Klasse von der inneren Klasse Objekte erzeugen.  
`class Schule{`  
    `// innere Klasse`  
    `public static class Schueler{`  
        `int alter;`  
    `}`  
    `public function void neuerSchueler(){`  
        `... new Schueler();`  
    `}`  
`}`  
## Innere Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit den normalen inneren Klassen kann man das Objekt welches instanziiert wird an die äußere Klasse binden.  
`class Schule{`  
    `public class Schueler{`  
        `int alter;`  
        `string name;`  
        `public void anKursTeilnehmen(){`  
            `print(Schule.this.name);`  
        `}`  
    `}`  
    `protected int anzahlSchueler;`  
    `public void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
        `Schueler hans = this.new Schueler();`  
        `hans.anKursTeilnehmen();`  
    `}`  
`}`  
## Anonyme innere Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die anonymen inneren Klassen werden bspw. im Zusammenhang mit den Methodenköpfen in einer abstrakten Klasse verwendet und werden nur ein einziges mal initalisiert, deklrariert, verwendet und dann wieder vom Speicher freigegeben.   
`abstract class Schule{`  
    `public string name;`  
    `protected int anzahlSchueler;`  
    `public function void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
    `}`  
    `pubic function void schuleAus();`  
`}`  
`Schule x = new Schule(){`  
    `public function void schuleAus(){`  
        `print("yeeey");`  
    `}`  
`};`  
`x.SchuleAus();`