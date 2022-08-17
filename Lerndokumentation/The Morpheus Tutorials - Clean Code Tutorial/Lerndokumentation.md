# Lerndokumentation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
1. Einführung und Struktur einer Klasse 
2. Law of Demeter
3. Prinzip der kleinsten Überraschung
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