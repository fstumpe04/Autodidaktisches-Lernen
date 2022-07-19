# Lerntagebuch 19.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Dynamic vs Static Scoping
## Dynamic vs Static Scoping [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Beim Static Scoping werden immer erst die Variablen und Inhalte verwendet, die innerhalb des selben Scopes(Codeblock) liegen.  
`int a = 42;`  
`int function foo(){`  
    `int res = a + 42;`  
`}`  
`int function bar(){`  
    `int a = 1337;`  
    `return foo();`  
`}`  
`foo();`  
`bar();`  

Hier wird in der `foo();`-Funktion die Variable `a` aus dem kompletten Datei-Scope verwendet, da dies die naheliegenste Initialisierung und Deklaration von `a` ist. Also `a = 42`.  

Beim Dynamic-Scoping würde hier die Variable tatsächlich überschrieben werden. Es würde also in der Funktion `bar();` die Variable `a` mit dem Wert `a = 1337` verwendet werden.  