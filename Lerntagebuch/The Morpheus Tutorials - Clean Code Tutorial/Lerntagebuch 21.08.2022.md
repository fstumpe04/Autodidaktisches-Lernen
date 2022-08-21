# Lerntagebuch 21.08.2022
1. Interface Segregation
2. Dependency Inversion
3. Single Level of Abstraction
4. Pfadfinderregel
5. Refactoring
## Interface Segregation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Interface Segregation ist eins von 5 SOLID-Prinzipien und besagt, dass eine Klasse immer nur von Interfaces erben sollte, die auch wirklich benutzt werden.   
## Dependency Inversion [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Dependency Inversion ist eins von 5 SOLID-Prinzipien und besagt, dass man keine unnötigen Abhängigkeiten zwischen seinen Objekten generieren sollte.  

CopyPaste  
--> Reader  
<-- ReaderUserInput  
--> Writer  
<-- WriterUserInput  
## Single Level of Abstraction [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Single Level of Abstraction besagt, dass man lieber den Code in mehrere Methoden auslagern sollte, statt seine Logik in nur einer Methode immer mehr zu verschachteln.  
`function foo(){`  
    `int i = algo1();`  
    `algo2(i);`  
    `algo3();`  
`}`  
`private algo1(){`  
    `if...{`  
        `algointern1();`  
    `}`  
`}`  
## Pfadfinderregel [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Pfadfinderregel besagt in der Softwareentwicklung, dass man wenn man Funktionen ändert, sie nicht nach außen verändert werden sollte.
## Refactoring [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Beim Refactoring sollte man folgende Dinge beachten.  
* Tesfälle einbauen
* Long Method vermeiden 
* CopyPaste vermeiden
* Feature Envy vermeiden bspw.: getA().getB().attrib1
* Data Class vermeiden
* God Class vermeiden
* Kommentare überflüssig machen