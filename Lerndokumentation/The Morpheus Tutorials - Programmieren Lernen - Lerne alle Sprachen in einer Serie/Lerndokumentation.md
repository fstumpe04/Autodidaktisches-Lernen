# Lerndokumentation Programmieren Lernen
1. Syntax (Zusammenfügungsregeln von Zeichen)
2. Semantik (Interpretationsregeln)
3. Variablen
4. Codefluss
5. Schwachtypisierte Programmiersprachen
6. Starktypisierte Programmiersprachen
7. Byte - Ganzzahlen
8. Short - Ganzzahlen
9. Integer - Ganzzahlen
10. Long, Long Long oder BigInteger - Ganzzahlen
11. Float - Fließkommazahlen
12. Double - Fließkommazahlen
13. Buchstaben - Character
14. Kommentare
15. Arrays
16. Mehrdimensionale Arrays  
## Einleitung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
### Syntax (Zusammenfügungsregeln von Zeichen)
Die Syntax ist das was man im Quelltext auf den ersten Blick sieht. Sie ist von Programmiersprache zu Programmiersprache unterschiedlich und ist das was man später neu an einer weiteren Programmiersprache lernen muss.
### Semantik (Interpretationsregeln)
Die Semantik ist die Bedeutung die der Quelltext hat, bzw. ist es das was der Quelltext in wirklichkeit ausführt.  
`int a = 5;`  
und  
`a = 5`   
haben die selbe Semantik.
## Variablen und der Codefluss [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
### Variablen
Variablen werden in einer Programmiersprache dazu verwendet, sie im Arbeitsspeicher (RAM = Random-Access Memory) zu speichern und im weiteren Verlauf der Durchführung des Programms zu verwenden.  
`int a = 5;`
`print (a); // Würde 5 ausgeben`
`a = 10;`
`print (a); // Würde 10 ausgeben`

Heisst je mehr Variablen man verwendet je mehr Arbeitspeicher wird genutzt und desto langsamer wird das Programm, da bspw. der Arbeitsspeicher so überfüllt ist, das auf die Speicherfreigabe von anderen Variablen gewartet werden muss. 

Initialisiert und deklariert wird eine Variable z. B. so:  
`int a = 5;`  
`int` ist hier der Datentyp.  
`a` ist hier der Variablenname.  
`=` sagt aus das der folgende Variablenwert zugewiesen wird.  
`5` ist hier der zugewiesene Variablenwert.  
`;` definiert das Zeilenende.  

Hierbei kann auch nur die Initialisierung: `int a;` und nur die Deklaration `a = 5;` druchgeführt werden.  

Hier dürfen auch keine Variablennamen mit Leerzeichen getrennt werden da sonst der Kompiler diese nicht lesen kann.

Für die Wertänderungen und die Speicherverwaltung generell, gibt es auch Referenzen die beliebig gesetzt werden können.

An sich haben Variablen unterschiedlich große Speicherkapazitäten.

### Codefluss
Der Codefluss an sich verläuft immer von oben nach unten und wird zeilenweise ausgeführt. Bei den einen Programmiersprachen wird das Zeilenende durch ein Zeichen deklariert (bspw. ein `;`), bei anderen wird das Zeilenende durch Zeilenumbrüche und Absätze dem Kompilier geläufig gemacht.
## Integer - Ganzzahlen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
### Schwachtypisierte Programmiersprachen
Müssen keinen fest definierten Datentyp definiert bekommen.  
Es reicht entwerder nichts, var oder ein $-Zeichen davor zu schreiben, damit der Kompiler selbst entscheidet welchen Datentyp der zugehörige Varaiblenwert hat.
### Starktypisierte Programmiersprachen
Benötigen zwingent einen von der Programmiersprache und selbst festgelegten Datentypen wie bspw. `int`.
### Byte - Ganzzahlen
Existieren in Programmiersprachen bspw. als: `int8_t` oder `byte`, sind 8 Bit also 1 Byte groß und es gibt sie in einer signed und unsigned Variante.  
Falls man mit dem übergeben Wert einen Punkt außerhalb der folgenden Range fallen würde, würde man wieder von Vorne bzw. von Hinten anfangen zu zählen. Das nennt sich auch Overflow  
C# Beispiel:  
// sbyte (signed Variante)  
Die niedrigste sbyte größe lautet: -128  
Die höchste sbyte größe lautet: 127  
// byte (unsigned Variante)  
Die niedrigste byte größe lautet: 0  
Die höchste byte größe lautet: 255
### Short - Ganzzahlen
Sind 16 Bit (2^16) groß und es gibt sie in einer signed und unsigned Variante.  
C#-Beispiel:  
// short (signed-Variante)
Die niedrigste short größe lautet: -32768
Die höchste byte größe lautet: 32767
// ushort (unsigned-Variante)
Die niedrigste ushort größe lautet: 0
Die höchste ubyte größe lautet: 65535
### Integer - Ganzzahlen
Sind 32 Bit (2^32) groß und es gibt sie in einer signed und unsigned Variante. 
C#-Beispiel:  
// int (signed-Variante)
Die niedrigste int größe lautet: -2147483648
Die höchste int größe lautet: 2147483647
// uint (unsigned-Variante)
Die niedrigste uint größe lautet: 0
Die höchste uint größe lautet: 4294967295
### Long, Long Long oder BigInteger - Ganzzahlen
Sind je nach Betriebssystem 32/64 Bit (2^32/2^64) groß und es gibt sie in einer signed und unsigned Variante.  
C#-Beispiel:  
// long (signed-Variante)
Die niedrigste long größe lautet: -9223372036854775808
Die höchste long größe lautet: 9223372036854775807
// long (unsigned-Variante)
Die niedrigste ulong größe lautet: 0
Die höchste ulong größe lautet: 18446744073709551615
// nint (signed-Variante)
Die niedrigste nint größe lautet: -9223372036854775808
Die höchste nint größe lautet: 9223372036854775807
// nuint (unsigned-Variante)
Die niedrigste nuint größe lautet: 0
Die höchste nuint größe lautet: 18446744073709551615
## Fließkommazahlen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
### Float - Fließkommazahlen
Werden immer mit einem `.` getrennt und durch Exponenten dargestellt.  
Beispiel: 2147*1-³ = 2.147 u. 11100111001*2-5 = 111001.11001  
Im Rechner wird IEEE754 zum umrechnen von Fließkommazahlen genutzt.  
Generel sind Fließkommazahlen eeher ungenau, da wenn man bspw. folgende Variable deklariert
`double a = 0.7;`  
der Varialbenwert 0.69999999999999995559107 usw. rauskommen kann.  

C#-Beispiel:  
// float.MinValue
Die niedrigste Floatgröße lautet: -3.4028235E+38
// float.MaxValue
Die höchste Floatgröße lautet: 3.4028235E+38
// float.Epsilon
Der Epsilon-Wert von float lautet: 1E-45
// float.NaN
Der NaN-Wert von float lautet: NaN
// float.NegativeInfinity
Der NegativeInfinity-Wert von float lautet: -8
// float.PositiveInfinity
Der PositiveInfinity-Wert von float lautet: 8
### Double - Fließkommazahlen
C#-Beispiel:  
// double.MinValue
Die niedrigste Doublegröße lautet: -1.7976931348623157E+308
// double.MaxValue
Die höchste Doublegröße lautet: 1.7976931348623157E+308
// double.Epsilon
Der Epsilon-Wert von double lautet: 5E-324
// double.NaN (Not a Number da der Computer nicht unendlich abbilden kann)
Der NaN-Wert von double lautet: NaN
// double.NegativeInfinity
Der NegativeInfinity-Wert von double lautet: -8
// double.PositiveInfinity
Der PositiveInfinity-Wert von double lautet: 8

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