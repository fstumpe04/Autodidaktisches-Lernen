# Lerntagebuch 24.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Atomare Operationen
2. synchronized
3. locks
4. Semaphoren
5. Deadlocks
## Atomare Operationen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Atomare Operationen sorgen dafür, dass wenn eine globale Variable innerhalb eines Threads gelesen oder ersetzt wird, der Thread nicht unterbrochen wird.  

Das gilt auch für alle primitiven Datentypen, die bereits in der Programmiersprache enthalten sind.
## synchronized [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Eine `synchronized`-Funktion sorgt innerhalb eines Threads dafür, dass der komplette Inhalt der Funktion im ganzen ausgeführt wird. Dieses Konzept wird auch "Thread save" genannt.
## locks [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ein `Lock`-Objekt sorgt auch dafür, dass der geschriebene Code nur aif einem Thread ausgeführt wird, stoppt aber auch alle anderen Threads.  

Das kann dzau führen, dass die Laufzeit länger dauert, als wenn man nur einen Thread erstellt, der den Code ausführt.  
`import Thread`  
`class MyThread implements Thread{`  
    `public function void run(){`  
        `for (int i = 0;i < 10;i++>){`  
            `l.acquire();`  
            `print(i);`  
            `l.release();`  
        `}`  
    `}`  
`}`  
`Lock l = new Lock();`
## Semaphoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit dem `Semaphoren`-Objekt kann man bestimmen, auf wie viele Threads man gerade zugreifen kann bzw. wie viele man gerade verwenden möchte. Man hat also `Lock`-Objkete, was wiederum heisst, das 1 `Semaphor`-Objekt == `Lock`-Objekt ist.  

Dieses Konzept nutzt man wenn man bspw. ein System nicht mit zu vielen Threads überlasten möchte.
## Deadlocks [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ein Deadlock also ein nicht verwendebarer Thread entsteht bspw. wenn man das selbe `Lock`-Objekt doppelt erwirbt. Dadruch kann man nämlich das erste erworbene `Lock`-Objekt nicht veröffentlichen.  

Am besten sollte man also immer erst ein `Lock`-Objekten veröffentlichen, bevor man ein neues oder das selbe `Lock`-Objekt erwirbt.  