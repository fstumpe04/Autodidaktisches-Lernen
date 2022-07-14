# Lerntagebuch 14.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Enums
## Enums [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Enum ist die Abkürzung von Enumeration was Aufzählung heisst.  

Dieses Konstrukt ermöglichtes es eine aufeinanderfolgende Menge von zusammenhängenden Werten gruppieren zu können, dies sorgt für eine bessere Lesbarkeit des Codes.  
`enum Richtung`  
`{`  
    `HOCH, RUNTER, LINKS, RECHTS`  
`}`  

Hier bennent man also einfach seine Aufzählung `enum Richtung` und schreibt einfach seine Werte mit einem Komma getrennt auf. Diese Werte sind unter der Haube Integer und werden standardmäßig wie beim Index bei Datenstrukturen beginnend mit dem Wert 0, 1, 2... usw. zugewiesen.