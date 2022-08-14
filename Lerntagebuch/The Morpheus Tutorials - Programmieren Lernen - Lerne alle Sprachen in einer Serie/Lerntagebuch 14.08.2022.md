# Lerntagebuch 14.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Generatoren
2. Dekoratoren
3. List Comprehensions
## Generatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Generatoren sind dazu gedacht unendlich lang ausgeführt zu werden, benötigen aber nicht die notwendige Rechenleistung, da sie durch das `yield`-Schlüsselwort angehalten wird.  
`function foo(){`  
    `a = 0;`  
    `b = 1;`  
    `yield a;`  
    `yield b;`  
    `while (true){`  
        `z = a + b;`  
        `a = b;`  
        `b = z;`  
        `yield z;`  
    `}`  
`}`  
`print(foo()); //0`  
`print(foo()); //1`  
`print(foo()); //1`  
`print(foo()); //2`  
`print(foo()); //3`  

Hier wird die Funktion immer bis zum yield ausgeführt und dann der Status der Funktion gemerkt.
## Dekoratoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Dekoratoren können dazu genutzten werden um Funktionen durch weitere Funktionen zu erweitern.  
`function benchmark_dec(f, param){`  
    `start = time.time();`  
    `f(param);`  
    `end = time.time();`  
    `print(end-start);`  
`}`  
`@benchmark_dec`  
`function foo(){`  
    `return param;`  
`}`  
## List Comprehensions [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
List Comprehensions sind durch Inline-Berechnungen neu erzeugte Listen.  
`celcius = [40, 41, 42, 30];`  
`fahrenheit = [((9/5)*x+32+y*x) for x in celcius for y in fib(20)];`  