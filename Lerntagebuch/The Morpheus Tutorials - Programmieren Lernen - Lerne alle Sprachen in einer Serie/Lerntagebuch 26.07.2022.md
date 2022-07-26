# Lerntagebuch 26.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Actors und Message Passing
## Actors und Message Passing [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Actors werden meistens von der Programmiersprache mit geliefert und werden dazu genutzt um Message Passing zu betreiben, also um Nachricht zu senden.  
`class MyActor extends Actor{`  
    `void function onReceive(object o){`  
        `String nachricht = (String)o;`  
    `}`  
`}`  
`MyActor m = new MyActor();`  
`m.send("Hallo");`  

Hier wird ein `String` an den `Actor` gesendet, sodass er innerhalb der von Actor geerbten Klasse verwendet werden kann.  

Unter der Haube hat der Actor seinen eigenen Thread und wartet permanent auf eine gesendete Nachricht, um sie zu bearbeiten.  