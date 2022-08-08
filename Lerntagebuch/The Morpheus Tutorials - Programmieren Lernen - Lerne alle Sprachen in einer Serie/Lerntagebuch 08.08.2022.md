# Lerntagebuch 08.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Pattern Matching mit Listen
## Pattern Matching mit Listen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Pattern Matching ist ein funktionaler Switch Case der es bei bspw. bei einer Liste ermöglicht, gewisse Dinge auszuführen, je nach dem wieviele Elemente sich innerhalb der Liste befinden.  
`liste = [1, 2, 3, 4, 5]`  
`switch (liste){`  
    `case[]:`  
        `print("liste leer");`  
    `case(x::[]):`  
        `print("erstes und einziges Element", x);`  
    `case(x::y::xs):`  
        `print("erstes und zweites Element", x, y);`  
    `case(x::xs):`  
        `print("erstes Element", x);`  
`}`