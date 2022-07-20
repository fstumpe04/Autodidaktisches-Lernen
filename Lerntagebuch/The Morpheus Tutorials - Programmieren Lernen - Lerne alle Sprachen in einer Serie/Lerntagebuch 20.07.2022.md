# Lerntagebuch 20.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Mixins
## Mixins [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei Mixins kann eine Klasse ohn Type Casting mit zwei oder mehr Klassentypen deklarriert werden, sodass man bspw. in einer Funktion die verscheiden Klassentypen zurückggeben kann.  
`class Maybe(a) = Just(a) | Nothing;`  
`class Just {`  
    `float a;`  
`}`  
`class Nothing {`  
`}`  
`Maybe function div(float a, float b){`  
    `if (b == 0) {`  
        `return new Nothing();`  
    `}`  
    `else {`  
        `return new Just (a/b);`  
    `}`  
`}`  

Hier wird das neue Objekt `Nothing();` zurück gegeben, falls diue Variable `b` einen Wert von 0 hat und damit nicht durch 0 geteilt wird. Ist die Variable `b` nicht 0 so ist der Rückgabewert ein neues Objket der Klasse `Just();`.  