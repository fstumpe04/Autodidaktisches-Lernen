# Lerntagebuch 13.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Überschreiben von Methoden
## Überschreiben von Methoden [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um eine Methode einer Oberklasse zu überschreiben, schreibt man eine Methode genau so in der Unterklasse auf.  

Dadurch erzeugt man eine dynamische Bindung die dafür sorgt, dass wenn man durch ein Array gemischt aus Ober- und Unterklassen iterriert, man immer die deklariert bzw. die überschrieben Methode nutzt.  
`class Schule`  
`{`  
    `public int anzahlSchueler;`  
    `public void neuerSchueler()`  
    `{`  
        `anzahlSchueler += 1;`  
    `}`  
`}`  
`class Gymnasium : Schule`  
`{`  
    `private bool hasSchueler;`  
    `public bool HasSchueler{get; set;}`  
    `public Gymnasium()`  
    `{`  
        `HasSchueler = false;`  
    `}`  
    `public void neuerSchueler()`  
    `{`  
        `if (HasSchueler)`  
        `{`  
            `anzahlSchueler += 1;`  
        `}`  
    `}`  
`}`  
`Gymnasium g = new Gymnasium();`  
`Schule meineSchule = g;`  
`Gymnasium g2 = new Gymnasium();`  
`Schule[] meineSchulen = {g, meineSchule, g2};`  
`foreach (var item in meineSchulen)`  
`{`  
    `item.neuerSchueler();`  
`}`  