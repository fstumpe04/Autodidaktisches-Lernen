# Lerntagebuch 03.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Objekt Serialisierung
## Objekt Serialisierung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei der Serialisierung eines Objekts speichert man die Instanz einer Klasse in einer Datei, um diese Datei woanders wieder einlesen zu können.  
`class A implements Serialization{`  
    `int a = 42;`  
    `int b = 1337;`  
`}`  
`A a = new A();`  
`File f = new File("meineDatei.png", "w");`  
`f.write(a.serialize());`  

Hier wird eine Datei bin mit der Instanz `a` beschrieben.  

Jetzt kann man die Datei lesen und die Instanz nutzen.  