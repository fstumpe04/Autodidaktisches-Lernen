# Lerntagebuch 15.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Operatoren überschreiben
## Operatoren überschreiben [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das Überschreiben von Operatoren wird häufig bei komplexen Zahlen genutzt und wird wie eine Methode in eine Klasse geschrieben inkl. des Operators der überschrieben werden soll.  
`class Complex{`  
    `public int real;`  
    `public int imaginär;`  
    `// real + i * imaginär`  
    `public static Complex operator +(Complex a, Complex b)`  
    `{`  
        `return new Complex(a.real + b.real, a.imaginär + b.imaginär);`  
    `}`  
`}`  