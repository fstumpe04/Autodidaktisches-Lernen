# Lerntagebuch 11.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Case Classes
## Case Classes [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Case Classes k?nnen im Rahmen des Pattern Matching, in dem man eine `case class` erstellt die die abzufragenden Inhalte enth?lt.  
`case class MyClass{`  
    `int a;`  
    `int b;`  
    `String s;`  
`}`  
`MyClass m = MyClass(42, 1337, "hallo");`  
`switch(m){`  
    `case MyClass(42, x, _) if x > 1000;`  
        `print("m hat auf jeden Fall a = 42 und bei b einen Wert > 1000");`  
`}`  