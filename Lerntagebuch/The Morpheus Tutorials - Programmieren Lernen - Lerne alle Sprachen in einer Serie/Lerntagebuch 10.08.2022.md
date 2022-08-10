# Lerntagebuch 10.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Pattern Guards
## Pattern Guards [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Pattern Guards differenzieren die Abfragen noch mehr, in dem weitere Bedinungen hint dem Case definiert werden können.
`liste = [1, 2, 3, 4, 5]`  
`switch (liste){`  
    `case[]:`  
        `print("liste leer");`  
    `case(x::[]):`  
        `print("erstes und einziges Element", x);`  
    `case(x::y::xs) y > 3:`  
        `print("erstes und alle Element ab dem dritten, wenn y größer als 0 ist", x, y);`  
`}`