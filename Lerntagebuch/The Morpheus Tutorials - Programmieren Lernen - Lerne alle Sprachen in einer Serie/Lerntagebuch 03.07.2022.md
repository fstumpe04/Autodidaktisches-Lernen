# Lerntagebuch 03.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Buchstaben - Character
2. Kommentare
3. Arrays
4. Mehrdimensionale Arrays

## Buchstaben - Character [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Der Character wir wie im folgenden ähnlich bie beim Integer deklariert und initalisiert.  
`char a = 'n';`  
Normalerweise wird der Wert in einfachen hochkomma Zeichen (') hinein geschrieben, es gibt aber auch Programmiersprachen wo diese in den doppelten hochkomma Zeichen (") geschrieben werden.  

An sich ist ein Character eine Ganzzahl wie ein Byte, also wird er auch mit der selben Range von 0 - 255 gespeichert.  

Buchstaben können in Zahlen umgewandelt werden und umgekehrt genau so.

Der ASCII-Zeichensatz bildet hier den Standard mit seinen 7 Bit also 127 Zecihen insgesamt.

Hier gibt es auch noch weiter Zeichensätze wie bspw. Unicode, damit auch Smiles oder ähnliches abgebildet werden kann.

## Kommentare [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Kommentare werden dazu verwendet den Überlick in seinem geschriebenen Quelltext zu behalten und sich auch noch nach Jahren wieder in den Quelltext einlesen zu können.  

Je nach Programmiersprache werden diese mit einem Route-Zeichen(#), doppelten Schrägstrichen(//) oder einem kleiner als Zeichen gefolgt von zwei Minus-Zeichen (<--) gekennzeichnet.

Kommentare werden immer vom Kompiler ignoriert!  

Es gibt Schlüsselwörter in den Kommentaren wie z.B. `//TODO:` um Aufgaben zu definieren oder auch Zusammenfassungen um aus den Kommentaren eine Dokumentation erstellen zu können.

## Arrays [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Arrays sind dazu da mehrere Variablen eines Datentyps zusammen zu fassen und neben einander im Speicher zu lagern.  

Statt also mehrere Variablen einzeln anlegen zu müssen,  
`int x1;`  
`int x2;`  
`int x3;`  
kann man also alle in eine Datenstruktur packen.  
`int[] a = new int[3];`  

Um die Variablen in dem Array nun verwenden zu können, nutzt man einen Index der immer bei 0 beginnt. Das heisst wenn man wie hier auf den Index 3 zugreifen würde, ergebe das einen Fehler da nur die Indexe 0, 1 und 2 existieren und hierfür der Speicherplatz belegt wurde.  

Die Wert werden also wie im folgenden zugewiesen und auch hier kann die Initalisierung und Deklaration in der selben Zeile durchgeführt werden.  
 
`int[] a = new int[3];`  
`a[0] = 1;`  
`a[1] = 2;`  
`a[2] = 42;`  
`int[] a = new int[] {1, 2, 42};`  
`int[] a = {1, 2, 42};`

## Mehrdimensionale Arrays [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Mehrdimensionalen Arrays sind an sich Arrays in Arrays und sind quasi eine Matrix.  

Es gibt sie in der Programmierung als 2D-Arrays ([Zeilen(Horizontal)][Spalten(Vertikal)]):  
`int[,] a = new int[3,3];`  
`a[0,0] = 1;`  
`a[1,0] = 2;`  
`a[2,0] = 42;`  
`a[0,1] = 2;`  
`a[1,1] = 5;`  
`a[2,1] = 1337;`  
`a[0,2] = 3;`  
`a[1,2] = 6;`  
`a[2,2] = 128;`  
`int[,] a = new int[,] {{1, 2, 42}, {2, 5, 1337}, {3, 6, 128}};`  
`int[,] a = {{1, 2, 42}, {2, 5, 1337}, {3, 6, 128}};`  
und in bestimmten Bereichen auch als 3D-Arrays ([X][Y][Z]):  

`int [,,] a = new int[2,2,2];`  
`a[0,0,0] = 1;`  
`a[0,0,1] = 2;`  
`a[0,1,0] = 42;`  
`a[0,1,1] = 5;`  
`a[1,0,0]= 1337;`  
`a[1,0,1] = 3;`  
`a[1,1,0] = 6;`  
`a[1,1,1] = 128;`  
`int [,,] a = new int[,,] {{{1, 2}, {42, 5}}, {{1337, 3}, {6, 128}}};`  
`int [,,] a = {{{1, 2}, {42, 5}}, {{1337, 3}, {6, 128}}};`  