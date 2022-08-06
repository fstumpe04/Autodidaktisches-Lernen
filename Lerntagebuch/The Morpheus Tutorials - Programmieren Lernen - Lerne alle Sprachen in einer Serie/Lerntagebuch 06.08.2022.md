# Lerntagebuch 06.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Absolute und Relative Pfade
2. Logging
3. Datum und Uhrzeit
4. Networking
## Absolute und Relative Pfade [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei der Angabe eines Dateipfads gibt es 2 verschiedene Arten die vom Betriebssystem zu Betriebssystem unterschiedlich sind, zum einen der absolute Pfad und zum anderen der relative Pfad.  

Der Absolute Pfad geht von dem Datenträger aus auf dem sich die Datei befindet.  
`import File`  
`File f = new File("C:\\Users\\Stumpe\\Documents\\meineDatei.txt");`  

Der Relative Pfad geht von dem Verzeichnis aus, in der sich die Assembly befindet.  
`import File`  
`File f = new File("\\Documents\\meineDatei.txt");`  
## Logging [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Beim Logging speichert man Informationen die sich im Betrieb des Programms ergeben in einer Datei ab.  
`import Logger`  
`Logger l = new Logger("modul");`  
`l.log(Logger.Stages.DEBUG, "Objket erfolgreich instanziiert");`  

Es gibt folgende Stages die man angeben kann, die darüber entscheiden wie viele und welche Informationen man weiter gibt.  
NOTSET = Quasi keine Infromationen
DEBUG = nur für den Programmierer
INFO = Informationen auf für den Benutzer
WARNING = Warnung tritt auf
ERROR = Fehler wurde geworden
CRITICAL = Programmabsturz
## Datum und Uhrzeit [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um mit Datum und Uhrzeit in einem Programm rechenen zu können, benötigt man die `DateTime`-Bibliothek.  
`import DateTime`  
`DateTime t = DateTime.now();`  

Hiermit kann man jetzt auf alle Daten die mit Datum und Uhrzeit zu tun haben zugreifen und sie beliebig formtatieren.  
`print(t.Format("DD.MM.YYYY"));`
## Networking [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um mit seinem Programm über das Internet kommunizieren zu können, nutzt man beim Networking Socketserver um eine Interneverbindung herstellen zu können. Dieses Konstrukt beinhaltet eine Server und eine CLientseite.  

Bei der Serverseite definiert man einen Port der möglichst nicht von anderen Programmen verwendet wird und wartet so lange bis von der Clientseite ein Objekt gesendet wird.  
`ServerSocket server = new ServerSocket(443);`  
`while(true){`  
    `Socket client = server.accept();`  
    ``print(client.recieve(1024));`  
    `client.close();`  
`}`  

Von der Clientseite wird eine Objket an die Serverseite geschickt.  
`Socker client = new Socket("84.22.109.112", 443);`  
`client.send("Hallo Welt");`  
`client.close());`  