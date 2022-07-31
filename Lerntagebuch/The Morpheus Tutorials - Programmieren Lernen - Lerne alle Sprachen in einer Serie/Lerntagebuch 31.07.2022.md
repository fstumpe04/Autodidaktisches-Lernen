# Lerntagebuch 31.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Vektoren
2. Zufall
3. Dateien
4. Dateien - Modi
## Vektoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Vektor bzw. Vektor3 ist eine 3D-Struktur, die quasi mit Koordinaten arbeitet.  
`import Vektor`  
`Vektor3 a = new Vektor3(1,0,1);`  
`Vektor3 b = new Vektor3(0,0,0);`  

Diese Vektoren kann man jetzt auch Verunden u. Verodern, was ähnlich wie bei den bitweisen Operatoren funktioniert.  

Es gibt auch noch eine Matrix, diese besteht aus mehreren Vektoren.  
`3x3 Matrix`  
`1 0 1`  
`1 2 1`  
`1 2 1`  
## Zufall [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um sich zufällige Werte ausrechnen lassen zu können, gibt es Zufallgeneratoren, die sich mit einer `Random`-Bibliothek in den Code einbauen lassen.  
`int i = random.random_int(1, 6);`  
Hier wird ien zufälliger gannzahliger Wert zwischen 1 und 6 zurückgegeben.  

Die meisten Programmiersprachen haben aber nur Funktionalitäten um einen Fließkommazahlwert von 0 bis 1 errechnen zu können.  
`float f = random.next();`  

Um hiermit nun das selbe Ergebnis mit einer Range von 1-6 erzielen zu können, multipliziert man einfach diesen Wert mit 6.  

Das Ergebnis lässt sich jetzt auch noch mit der `ceit()`-Methode Aufrunden, mit der `floor()`-Methode Abrunden und mit der `round()`-Methode kaufmännisch Runden.  

Um jetzt nur eine bestimmte ANzahl an Nachkommastellen errechnet zu bekommen, muss man entweder den Parameter lutiplizieren oder durch das Ergebnis dividieren.
## Dateien [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um eine Datei verwenden zu können, nutzt man eine `File`-Bibliothek.  
`File f = new File("meineDatei.txt","r");`  
`String[] zeilen = f.readlines();`  

Hier wird der komplette Dateiinhalt Zeile für Zeile in ein String-Array geschrieben. Hier sollt eman aufpassen, da der Arbeitsspeicher bei einer zu vollen Datei sonst komplett voll geschrieben werden kann.  

Man kann eine `File`-Instanz sowohl im Readmodus erzeugen, dann wird nach der angegeben Datei gesucht, als auch im Writemodus erzeugen, dann wir die angegeben Datei erzeugt falls sie nicht vorhanden ist.  

Um die Datei hinterher wieder verwenden zu können, muss diese geschlossen werden `close()` und mit der `read()`-Methode kann man eine Anzahl von Zeichen übergeben, die man lesen möchte.
## Dateien - Modi [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Es gibt verschiedene Modi womit man Dateien instanziieren kann.  
* r = nur Lesen der Datei
* r+ = r + Sschreiben wird vom Cursor vorne hinzugefügt
* w = Datei neu Erstellung und Überschreibung der Datei
* w+ = w + Lesen
* a = Schreiben aber nur hinten anfügen + neu Erstellung der Datei falls nicht vorhanden
* a+ = a + Lesen mit dem Cursor am Ende der Datei

Um den Cursor in der Datei verschieben zu können, gibt es die `seek()`-Methode der man einen Wert übergeben kann um an die Stelle in der Datei zu springen an der man mit den Cursor springen will.  