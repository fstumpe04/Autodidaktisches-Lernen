# Lerntagebuch 05.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Flushing
## Flushing [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Flushing wird benötigt um den Buffer bspw. bei Dateien freizugeben.  
`File f = ...`  
`int i = 0`  
`while (true){`  
    `f.write('a')`  
    `i++`  
    `if(i % 1000){`  
        `f.flash()`  
    `}`  
`}`  
 Hier wird immer bei `i = 1000` der gefüllte Buffer in die Datei geschrieben.  