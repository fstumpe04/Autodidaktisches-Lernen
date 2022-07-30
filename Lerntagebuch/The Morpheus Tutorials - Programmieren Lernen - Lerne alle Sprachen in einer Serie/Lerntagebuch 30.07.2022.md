# Lerntagebuch 30.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Testen
2. Exceptions
3. Eigene Exceptions
4. RegEx - Regul�re Ausdr�cke
## Testen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um seine Code zu testen, kann man verschiedene Testarten einsetzten. 

Die bekannteste Testart ist Unittesting. Diese Testart testet die Funktionalit�ten von Klassen.  

Hier sollte man spezielle Testf�lle je Objekt inkl. deren Zusammenh�nge schreiben, um sich keinen unn�tigen Aufwand zu machen.  
`class MyTest extends TestCase{`  
    `public void teste_meineFkt(){`  
        `assert(meineFkt(), "irgendwas");`  
    `}`  
`}`  
## Exceptions [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Exceptions nutzt man um Fehler die zur Laufzeit passieren abfangen zu k�nnen.  
`int meinArray = {1,2};`  
`try{`  
    `print(meinArray[2]);`  
`}`  
`catch Exception e{`  
    `print("exception");`  
`}`  
`finally{`  
    `print("Hallo");`  
`}`  

Hier wird ein Fehler geworfen, da auf ein Index im Array zugegriffen wird, der nicht definiert ist.  

Es gibt verschiedene Exception-Typen wie z.B. FileNotFoundException, IOExeption, usw. um den Fehler differenzieren zu k�nnen.  
## Eigene Exceptions [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Man kann auch eigen Exceptions bauen, in dem man einfach von der Klasse `Excpetion` erbt.  

Je nach Programmiersprache wirft man dann diesen Fehler mit einem Schl�sselwort `throw` o. `rasie`.  
`class meinFehler extends Exception{`  
    `public meinFehler(String msg){`  
        `super(msg);`  
    `}`  
`}`  
`function void meinFkt(int[]) meinArray){`  
    `if(meinArray.length == 0){`  
        `throw new meinFehler("Fehler: Array ist leer");`  
    `}`  
`}`  
## RegEx - Regul�re Ausdr�cke [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Regul�re AUsdr�cke (kurz RegEx) werden dazu verwendet um den richtigen Inhalt eines Strings zu ermitteln, man verleicht also kruz gesagt Strings.  
`regex("").match(String);`  

In so einem Ausdruck kann man jetzt verschieden Dinge definieren.  
* [Hh] => gro�es oder kleines H
* [^Hh] => alles was nicht gro�es oder kleines H ist
* [a-z] => alle kleinen Buchstaben von a-z
* \s => Whitespace
* \S => alles was kein Whitespace ist
* \d => Zahl
* \D => alles was keine Zahl ist
* ...{2} =>Anzahl wie oft der Ausdruck hintereinander stehen soll.
* ...|... => Zum veroderen der Ausdr�cke
* a? => Ein a oder kein a
* a* => Beliebig oft a
* a+ => Mindestens ein a
* a{1,} => Mindestens 1 a
* a{3,5} => Je nach Programmiersprache 3-5 o. 3 u.5 mal a
* \# => Route Symbol
`\#([a-f]|[A-F]|[0-9]){3,6}`
Dies ist ein regul�rer Ausdruck um eine Hexadezimalzahl ermitteln zu k�nnen.