# Lerntagebuch 09.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Wildcards mit Pattern Matching
## Wildcards mit Pattern Matching [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Wildcards werden beim Pattern Matching dazu verwendet, gewisse Elemente über das Pattern auszulassen, die nicht mit behandelt werden.  
`liste = [1, 2, 3, 4, 5]`  
`switch (liste){`  
    `case[]:`  
        `print("liste leer");`  
    `case(x::[]):`  
        `print("erstes und einziges Element", x);`  
    `case(x::_::xs):`  
        `print("erstes und alle Element ab dem dritten", x, y);`  
`}`