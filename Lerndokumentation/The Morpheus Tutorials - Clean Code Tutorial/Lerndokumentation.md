# Lerndokumentation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
1. Einführung und Struktur einer Klasse
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