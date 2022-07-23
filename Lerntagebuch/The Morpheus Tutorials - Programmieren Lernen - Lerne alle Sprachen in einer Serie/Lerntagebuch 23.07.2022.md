# Lerntagebuch 23.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Typschranken
2. Prozesse und Threads
3. Threads erstellen
4. Nebenläufigkeit von Threads
## Typschranken [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit Typschranken kann man den Typen `T` den man bei Generics übergibt auf eine Auswahl von Typen begrenzen.  
`function T[] sort<T extends String>(T element){`  
    `return element.split(' ');`  
    `//...`  
`}`  

Hier wird der Typ `T` auf das Objekt `String` und deren verebten Klassen begrenzt, es kann also nur einer dieser Typen an die generische Funktion übergeben werden. Dadurch kann man hier auch die `split()`-Methode aus der String-Klasse verwenden, da man sicher sein kann das diese exisitert.  
## Prozesse und Threads [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Normalerweise startet ein Programm auf einem Computer als Prozess mit bspw. folgenden Inhalten.  `CODE|DATA|FILES|`  

Diese Inhalte können auch auf Threads mit folgendne Inhalten aufgeteilt und quasi parallel ausgeführt werden.  
`THREAD1: REGISTER|STACK`
`THREAD2: REGISTER|STACK`

Es gibt Programmiersprachen die nur mehrere Prozesse erzeugen ("Forken") und keine Threads erzeugen und umgekehrt genauso.  

Threads haben an sich immer einen Status.  
`new Thread()-----> New`  
`<----start()-----> Runnable`  
`<----run()-------> Running`  
`<----sleep()-----> Waiting // Hier kann die feste Dauer übergeben werden`  
`<----wait()-----> Waiting // Hier wird so lange gewartet bis wieder der Befehl notifiy() ausgeführt wird`  
`<----notify()-----> Running`  
`<----return/SIGKILL()-----> DEAD // Thread wird gelöscht/entfernt`  
## Threads erstellen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um Threads erstellen zu können, benötigt man meistens eine Bibliothek.  
`Runnable`(Java) o. `Thread`(Python) o. `Threading`(C#)  

In Java muss man von `Runnable` erben und die `run()`-Methode überschreiben.  
`import Thread`  
`class MyThread implements Thread{`  
    `public function void run(){`  
        `for(int i = 0;i < 1000000;i++){`  
            `print(i);`  
        `}`  
    `}`  
`}`  
`Thread t = new MyThread(); // Erstellt den Thread und startet ihn automatisch.`  
`t.run(); // Ändert den Status zu Running`  
`exit(0); // Beendet den Thread`  

Je nach Programmierpsrach muss man den Thread nach der Initialisierung manuel starten und meistens läuft eine zweiter Thread der mit erstellt wurde nach dem beenden des ersten Threads weiter.  
## Nebenläufigkeit von Threads [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Falls man mehrere Threads gleichzeitig instanziiert, kann man als Programmierer nicht sicher sein, welcher jetzt wann und an welcher Stelle durchläuft, da diese immer unterschiedlich druchlaufen werden.  
`import Thread`  
`class MyThread implements Thread{`  
    `public function void run(){`  
        `for(int i = 0;i < 10;i++){`  
            `print(i);`  
        `}`  
    `}`  
`}`  
`Thread t = new MyThread();`  
`Thread t12 = new MyThread();`  
`t.run();`  
`exit(0);`  
`Ausgabe: 01234012356897894567`  