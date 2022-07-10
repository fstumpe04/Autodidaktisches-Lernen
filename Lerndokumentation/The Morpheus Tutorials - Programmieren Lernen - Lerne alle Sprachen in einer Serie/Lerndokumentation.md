# Lerndokumentation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
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
17. Listen
18. Mehrdimensionale Listen
19. Strings
20. Unicode-Zeichensatz
21. Arithmetische Operatoren
22. IF-Verzweigungen
23. Booleans und Vergleichsoperatoren
24. Logische Operatoren
25. Bitweise Operatoren
26. While Schleifen 
27. for-Schleifen
28. foreach-Schleifen
29. break und continue
30. Funktionen 
31. Rückgabewerte
32. Parameter
33. Rekursion
34. Default Argumente 
35. Call-by-Value vs Call-by-Reference
36. Lazy Evaluation
37. Function Pointer
38. Lambda Funktionen
39. Inline Funktionen
40. Code lesen
41. Klassen
42. Methoden
43. Konstruktoren
44. Zugriffsmodifikatoren
45. Getter/Setter
46. Static - Klassenvariablen
47. Vererbung
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
## Listen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Im Gegensatz zu den Arrays muss bei den Listen der Speicher der belegt werden soll nicht vorher definiert werden.  

`a = [42, 1337, 128, 256]`

Um nun einer Liste einen Wert hinzuzufügen bentuzt man die Add-Funktion.  

Mit der Len-Funktion gibt man die Anzahl an Elementen die sich in der Liste befinden zurück.

Funktionen wie Push() und Pop() können der Liste ebenfalls eine Element hinzufügen bzw. ein Element aus der Liste entfernen.  

Grundsätzlich sind Listen langsamer als Arrays, da sie eine längere Zugriffzeit benötigen um auf ein Element zugreifen zu können.

Bei einer Liste bekommt ein Element immer die Speicheraddresse des nächsten Element zugewiesen, diese Datenstruktur nennt man auuch Linked List.

42-->1337-->128-->256

Um hier also an die 256 zu kommen muss man also durch die gesamte Liste durchgehen, man hat also 4 Zugriffszeiten.

Es gibt auch eine Double Linked List, bei der auch die Speicheraddresse des vorherigen Elements im Element gespeichert wird und sogar das erste mit dem letzten verkettet ist.

42<-->1337<-->128<-->256  
<----------------------------->  
## Mehrdimensionale Listen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mehrdimensionale Listen funktionieren genau so wie die mehrdimensionalen Arrays, heisst es werden Listen in Listen gespeichert.
## Strings [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Strings sind Zeichenketten, also nicht anderes als variabel Große Char-Arrays bzw. Listen aus Chars.  

`string a = "irgendwas";`

Falls hier von der Programmiersprache ein Array genutzt wird, wird unter der Haube von der Programmiersprache selbst immer ein neues Array angelegt falls sich die Größe des Arrays ändert.  

Die einzelnen Chars in einem String können also auch mit einem Index behandelt werden.  

Der Backslash (umgekehrten Schrägstrich) hat in einem String eine besondere Bedeutung und zwar dient dieser als Markierungszeichen um ein Special-Char nutzen zu können.  

Diese Special-Chars sind bspw. `"\n"` um einen Zeilenumbruch druchzufügren oder `"\t"` um einen Tabulator einzufügen.

Falls man nun einen Backslash in seinen String schreiben möchte, schreibt man einfach einen weiteren Backslash davor damit derKompiler diesen wieder als Backslash identifizieren kann.

Um einen String an sich zu identifizeren schreib man doppelte Anführungszeichen (") vor und hinter die Zeichenkette, falls auch hier das doppelte Anführungszeichen innerhalb der zeichenkette genutzt werden soll, schreibt man auch ein Backslash davor.
## Unicode-Zeichensatz [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit dem Unicode Zeichensatz kann man durch Special-Chars nun bspw. Smiles in seinen Strings einfügen.  

Dies tut man in dem man \u gefolgt von der gewünschten Hexadezimalzahl in den String schreibt.  

Diese Hexadezimalzahl steht bspw. für ein Herz:  
`"\u2665"`

Eine Tabelle mit sämtlichen Unicode-Zeichen inkl. Hexadezimalenzahlen findet man hier:  
https://unicode-table.com/de/
## Arithmetische Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Es gibt 5 arithmetische Operatoren. Plus, Minus, Mal, Geteilt und Modulo.  
`a = x+y;`  
`a = x-y;`  
`a = x*y;`  
`a = x/y;`  
`a = x%y;`  

Auch hier kann ein Overflow im Speicher entstehen wenn man nach der Berechnung die Range des Datentypen über- bzw. unterschreitet.

Bei dem Geteilt-Operator muss beachtet werden, das nich durch 0 geteilt wird da der zurückgegebene Wert sonst NaN ist und für Fehler im Programm sorgen kann.

Der Modulo-Operator wird dazu verwendet um nur den Rest einer Division in einer Variablen zu speichern. Dies wird häufig bei Grafikprogrammierung genutzt.

`int x = 5;`  
`int y = 3;`  
`int z = x % y;`  
5/3 = 1 R = 2 also ist Z = 2

Es gibt auch die Möglichkeit Variablen mit einem anderen Wert zu verändern, was mit allen arithmetischen Operatoren funktioniert.  
`y += 1;` oder `y = y + 1;`  
`y -= 1;` oder `y = y - 1;`  
`y *= 1;` oder `y = y * 1;`  
`y /= 1;` oder `y = y / 1;`  
`y %= 1;` oder `y = y % 1;`  

Um einen Wert um eine Stufe zu vergrößern bzw. zu verkleinern (Inkrementierung/Dekrementierung), kann man auch eine vereinfachte Schreibweise verwenden.  
y++; u. y--;  

Hier gilt zu beachten, dass wenn man den inkrementierten Wert übergeben will die Varaible hinter die Operatoren schreiben muss.  

`int x= 5;`  
`int y= 3;`  
`int z= y++;`  
`// z = 3, y = 4`  
`int w= ++x;`  
`// w = 6, x = 6`  
Expontenten werden wie folgt gekennzeichnet:  
`int z = x**y;` oder `int z = x^y;` oder `int z = Math.Pow(x, y);`
## IF-Verzweigungen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Wird dazu benötigt seinen Code zu strukturieren und um mit Bedingungen arbeiten zu können. 

Um einen if-Block zu beginnen, schreibt man das if-Schlüsselwort, gefolgt von der Bedingung, gefolgt von den gescheiften Klammern in dem der Code steht der ausgeführt werden soll, wenn die Bedingung erfüllt worden ist.  
`if (BEDINGUNG)`  
`{`  
  `// irgendwelcher Code`  
`}`  

bei Bedingungen werden Vergleichüberprüfung vor genommen die mit einem doppelten Gleichheitszeichen geschrieben werden.  
`if (x == 42)`  

Das else-Schlüsselwort sorgt dafür, dass immer etwas ausgeführt wird falls keine der vorherigen if-Bedingungen erfüllt worden sind.  
`if (BEDINGUNG)`  
`{`  
  `// irgendwelcher Code`  
`}`  
`else`  
`{`  
  `// irgend ein ausnahme Code`  
`}` 

In der Verbindung mit beiden Schlüsselwörtern also `else if` kann man nun auch weitere Bedingungen in dem IF-Block hinzufügen, um andere Bedingungen ablaufen zu können.

`if (BEDINGUNG)`  
`{`  
  `// irgendwelcher Code`  
`}`  
`else if (BEDINGUNG)`  
`{`  
  `// irgend ein anderer Code`  
`}`  
`else`  
`{`  
  `// irgend ein ausnahme Code`  
`}`  
## Booleans und Vergleichsoperatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Booleans werden häufig mit bool abgekürzt, sind 1 Bit groß und können sowohl 0=false als auch 1 = true sein.  

Bei einer IF-Verweigung kann man diesen Datentypen mit einem sogenannten Vergleichsoperator (==)verwenden, um einen bestimmte Bedingung zu definieren.  
`bool x = true;`  
`bool y = true;`  
`bool wahrheit = x == y;`  
`if (wahrheit){`
`}`

Hier wird also der Code in dem if-Block ausgeführt da x und y gleich sind.  

Es gibt auch noch Verlgeichssoperatoren die Abfragen ob etwas größer (>), kleiner (<), größergleich (>=) oder kleinergleich(<=) dem folgenden Wert ist.  

Falls man auch Ungleichheit prüfen möchte, gibt es auch noch die folgenden Schreibweisen:  
`x != y;` oder `x <> y;` oder `x ~= y;`  

Ein boolscher Wert kann auch negiert werden so das immer der gegenteilige Wert übergeben wird.  
`bool falschheit = !wahrheit;`
## Logische Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die logischen Operatoren können mit boolschen Werten verknüpft werden.  

Der Und-Operator (AND o. &&) ist nur wahr wenn beide Werte wahr sind.  
`bool log = true;`  
`bool log2 = true;`  
`bool ergebnis = log && log2;`  

Der Oder-Operator (OR o. || o. ^) gibt wahr zurück wenn mindestens ein Wert wahr ist, also gibt er nur falsch zürck wenn beide Werte falsch sind.  
`bool ergebnis = log || log2;`  

Falls man nun beide Operatoren in einer Bedingung verwenden möchte, hat der Und-Operator (AND o. &&) eine stärkere Gewichtung als der Oder-Operator (OR o. || o. ^). Dies ist vergleichbar mit der Punkt vor Strich-Rechnung aus der Mathematik.  
`if ((a && b) || (a && c)){`  
`}`  

Hier können aber auch Klammern gesetzt werden, um die Oder-Verknüpfung zuerst ausführen lassen zu können.  
`if (a && (b || a) && c){`  
`}`  
## Bitweise Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Bitweisen Operatoren sind ähnlich wie die logischen operatoren, werden aber auf ganzzahlige Werte angewendet.  

Hier werden meistens Hexadezimale- (0x...) oder Binärzahlen(0b...) verwendet.  
0123456789ABCDEF (0-15)  = 4 Bit o. 2^4  

Bei den Bitweisen Operatoren wird also jedes einzelne Bit mit dem bitweisen Und- (&) oder Oder-Operator (|) verglichen.  

Bitweiser Und-Operator (&):  
`int bitmaske = 0x000F;`  
`int wert = 0xAAAA;`  
`int ergebnis = wert & bitmaske;`  
1010 1010 1010 1010  
0000 0000 0000 1111  
0000 0000 0000 1010  
`int ergebnis = 0x000A;`  

Bitweiser Oder-Operator (|):  
`int bitmaske = 0x000F;`  
`int wert = 0xAAAA;`  
`int ergebnis = wert | bitmaske;`  
1010 1010 1010 1010  
0000 0000 0000 1111  
1010 1010 1010 1111  
`int ergebnis = 0xAAAF;`  

Sowohl bei den logischen als auch bei den bitweisen Operatoren gibt es auch noch den Entweder/Oder-Operator (XOR o. ^), der immer dann wahr zurück gibt, wenn nur einer der beiden Werte wahr ist. Also wird hier immer wenn beide Werte gleich sind falsch zurück gegeben.  

Bitweiser Entweder/Oder-Operator (XOR o. ^):  
`int bitmaske = 0x000F;`  
`int wert = 0xAAAA;`  
`int ergebnis = wert ^ bitmaske;`  
1010 1010 1010 1010  
0000 0000 0000 1111  
1010 1010 1010 0101  
`int ergebnis = 0xAAA5;`  

Es gibt auch noch das Bitshiften, womit man eine vorgegebene Anzahl an Bits aus einer Bitreihe vorne oder hinten abkappt, die verleibenden Bits aufrücken lässt und die leeren Plätze mit den selben Bitwerten füllt wie der naheliegenste Bit.  
`int wert = 0xAAAA;`  
1010 1010 1010 1010  
`int ergebnis = wert >> 3;`  
1111 0101 0101 0101  

`int bitmaske = 0x000F;`  
0000 0000 0000 1111
`int ergebnis = bitmaske >> 3;`  
0000 0000 0000 0001  

Mit dem erweiterten Bitshift-Operator (>>>) kann man auch festlegen, dass die leeren Plätze immer mit 0 aufgefüllt werden sollen.  

`int wert = 0xAAAA;`   
1010 1010 1010 1010  
`int ergebnis = wert >> 3;`  
1111 0101 0101 0101  
`int ergebnis = 0xF555;`  

Das funktioniert aber nur die Rechte-Richtung!  

Das gleiche funktioniert auch in die andere Richtung, nur wird hier immer mit 0 aufgefüllt.

`int wert = 0xAAAA;`   
1010 1010 1010 1010  
`int ergebnis = wert << 3;`  
0101 0101 0101 0000  
`int ergebnis = 0x5550;`
## While Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Schleifen sorgen generell dafür Code mehrfach ausführen zu können.  

Bei der while Schleife wird der Code solange mehrfach ausgeführt, wie die Bedingung erfüllt also wahr ist.  
`while (BEDINGUNG){`  
`}`  
o.  
`while (BEDINGUNG){`  
`}`  

Wenn sich die Bedingung im Code nie ändert, erzeugt man eine Endlosschleife, die den Code permanent ausführt.  
`bool wahrheit = true;`  
`while (wahrheit){`  
    `// Endlose Code ausführung`  
`}`  

Um nun einen Code nur um eine bestimmte Anzahl nach wiederholt auszuführen, arbeitet man hier mit den kleiner o. größer als Vergleichoperator und einem ganzzahligen Wert als Bedingung und einer Inkrementierung/Dekrementierung des zuvor gennanten ganzzahligen Wertes.  
`int i = 0;`  
`while (i < 42){`  
    `print("hello");`  
    `i++;`  
`}`

Es gibt auch nich die do-while Schleife die man dann verwenden kann, wenn man den Code innerhalb der Schleife mindestens einmal ausführen will.  
`int i = 0;`  
`do {`  
    `print("hello");`  
    `i++;`  
`} while (i < 42);`  
## for-Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ist eine Alternative zu while-Schleifen und wird eher genutzt wenn man etwas durchzählen möchte.  
`for (int i = 0; i < 42; i++)`  
`{`  
    `// Schleifenrumpf`  
`}`  

Hier würde man von 0-41 in Einzelschritten druchiterieren.  

Dies Form von Schleifen werden auch häufig für Arrays oder Listen verwendet.  
`int[] meinArray = {42, 1337, 42, 42, 42};`  
`for (int i = 0; i < meinArray.Length; i++)`  
`{`  
    `System.Console.WriteLine(meinArray[i]);`  
`}`  

Hier würde jedes Element aus dem Array hintereinander auf der Konsole ausgegeben werden.  

Die Variable `int i;` kann nur in dem for-Schleifenrumpf verwendet werden, da diese nur dort bekannt ist. Nach den Schleifendruchläufen wird der belegte Speicher hierfür also frei gegeben.
## foreach-Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Wird dazu verwendet um bspw. jedes Element eines Arrays zu durchlaufen.  
`int[] meinIntArray = {42, 1337, 42, 42, 42};`  
`foreach (int element in meinIntArray)`  
`{`  
    `System.Console.WriteLine(element);`  
`}`  

Hier wird jede Zahl in dem zuvor definierten Array auf der Konsole ausgegeben.  

Für String-Arrays ist diese Form von Schleifen auch sehr praktisch.  
`string[] meinStringArray = {"42", "dieses", "tut", "ist", "geil"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine(element);`  
`}`  

Diese Form von Schleifen kommt häufig in schwachtypisierten Programmiersprachen vor.  
## break und continue [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
`break` und  `continue` sind Schlüsselwörter die in Schleifendruchläufen dazu verwendet werden, diese zu unterbrechen.  
### continue
Bei dem Schlüsselwort `continue` wird der derzeitige Schleifendurchlauf an der Stelle unterbrochen und es wird direkt zum nöchsten Schleifendurchlauf gesprungen.  
`string[] meinStringArray = {"42", "dieses", "tut", "ist", "geil"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine("abc");`  
    `continue;`  
    `System.Console.WriteLine(element);`  
`}`  

Hier würde also 5 mal `abc` auf der Nosole ausgegeben werden, da `print(element);` hinter dem `continue` steht.  

Dies funktioniert in jeglicher Form von Schleifen.  

Nun kan mauch IF-Verzweigungen mit dem `continue` verwenden um dies nur unter einer Bedingung ausführen zu lassen.  
`foreach (string element in meinStringArray)`  
`{`  
    `if (element == "42")`  
    `{`  
        `continue;`  
    `}`  
    `System.Console.WriteLine(element);`  
`}`  

Hiuer wird also nur `diesestutistgeil` auf der Konsole ausgegeben.  

Wenn man generell das `continue` am Ende der Schleife setzt, verschwendet man nur unnötige Rechenzeit, da man ncihts überspringt.  
### break
Das Schlüsselwort `break`sorgt auch dafür das der Schleifendurchlauf unterbrochen wird, nur werden hier bei alle weiteren Schleifendurchläufe die noch kommen sollten nich mehr ausgeführt.  
`string meinStringArray = new string[] {"dieses", "tut", "ist", "geil","42", "hi", "wtf", "ist"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine(element);`  
    `if (element == "geil")`  
    `{`  
        `break;`  
    `}`  
`}`  

Hier wird nur `diesestutistgeil` ausgegeben und es mach Sinn das `break` vor dem Schleifenende auszuführen, da man hier noch etwas unterbricht.  
## Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Benötigt man um Code auslagern zu können den man mehrfach ausführen will.  

Nennt man meißtens foo o. bar o. baz. und man definiert sie mit dem Schlüsselwort def o. function davor.  
`function foo()`  
`{`  
    `System.Console.WriteLine("***STARTE DAS PROGRAMM***");`  
    `System.Console.WriteLine("_________________________");`  
`}`  

Diese Funktion kann man nun über den Funktionsnamen und den runden Klammern aufrufen und z.B. in einer Schleife mehrfach ausführen.  
`for (int i = 0; i < 10; i++){`  
    `foo();`  
`}`  

Diese Art kennt man auch aus der Mathematik.  
`f(x) = 2*x`  
## Rückgabewerte [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Rückgabewerte weerden dazu benötigt um etwas von einer Funktion zurückgeben zu können.  

Falls man keinen Rückgabewert verwenden möchte, nutzt man hier den Wert `void`.  
`void function foo(){`  
`}`  

Um nun einen Wert von einer Funktion zurückgeben zu können, gibt man hier statt `void` einen Datentyp wie z.B. `int` an und gibt den Wert mit dem Schlüsselwort `return` zurück.  
`int function foo(){`  
    `int ergebnis = 42*1337;`  
    `return ergebnis;`  
`}`  

Zu beachten gilt hier, das der Code nach dem `return` nicht mehr ausgeführt wird.  

Falls man nun eine IF-Verzweigung innerhalb der Funktion nutzen möchte, muss man immer daran denken ein `return` zurückzugeben, sonst würde ein Fehler entstehen.  
`int function foo(){`  
    `int ergebnis = 42*1337;`  
    `bool abc = true;`  
    `if (abc){`  
        `return ergebnis;`  
    `}`  
    `else`  
    `{`  
        `return 0;`  
    `}`  
`}`  

Ein besserer Programmierstil ist hier eine Variable `int ret` anzulegen, da man hier nur auf den Wert der Variablen achten muss und nicht jedes mal `return` schreiben muss.  
`int function foo(){`  
    `int ergebnis = 42*1337;`  
    `bool abc = true;`  
    `int ret = 0;`  
    `if (abc){`  
        `ret = ergebnis;`  
    `}`  
    `return ret;`  
`}`  

Nun kann man den Rückgabewert aus der Funktion in eine Variable schreiben. Dabei gilt zu beachten, dass die Varaible und die Funktion den selben Datentyp haben.  
`int meinInteger = foo();`  
## Parameter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Parameter können über die runden Klammern an die Funktion übergeben werden.  
`int function foo(bool abc){`  
    `int ergebnis = 42*1337;`  
    `int ret = 0;`  
    `if (abc){`  
        `ret = ergebnis;`  
    `}`  
    `return ret;`  
`}`  
`int meineVar = foo(true) // Ergebnis von 42 * 1337`  
`int meineVar2 = foo(false) // 0`  

Der Parameter muss hier, ähnlich wie bei den Rückgabewerten, den selben Datentyp haben wie die übergebene Variable.  

Damit lassen sich auch Funktionen anandere zur Verwendung weitergeben.  

Man kann auch mehrere Parameter an eine Funktion übergeben und nutzen.  
`int function foo(bool abc, int def, int hij){`  
    `int ergebnis = def*hij;`  
    `int ret = 0;`  
    `if (abc){`  
        `ret = ergebnis;`  
    `}`  
    `return ret;`  
`}`  
`bol meinBool = true`  
`int meineVar = foo(meinBool, 42, 1337) // 0`  

Die Parameter sind also Platzhalter die für verschiedene Ergebnise einer Funktion sorgen kann.  
## Rekursion [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Rekursion bedeutet das sich eine Funktion selbst x mal aufruft. Damit lassen sich auch Funktionen wie die Fakultät 10! = 10*9*8*7...! oder die Fibonacci-Folge 0,1,1,2,3,5,8,13... aus der Mathematik berechnen und abbilden.  
int function fakul (int n){
    if (n <= 2){
        return n;
    }
    return n * fakul (n - 1);
}
int meineVar = fakul(10);  
fakul(10)  
--> 10*fakul(9)  
----> 9*fakul(8)  
------> 8*fakul(7)  
--------> 7*fakul(6)  
----------> 6*fakul(5)  
------------> 5*fakul(4)  
--------------> 4*fakul(3)  
----------------> 3*fakul(2) = 3*2  
------------------> 2  

Es ist immer wichtig einen Abbruchfall bei einer Rekursion einzubauen, da sonst die Funktion unendlich aufgerufen wird.
## Default Argumente [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Als Parameter einer Funktion kann auch ein Defaul Argument gesetzt werden, welches immer dann vergeben wird, wenn der Parameter beim Aufruf nicht gesetzt wird.  
`int function foo (bool abc = true){`  
`}`  
`int meineVar = foo();`  

Bie mehreren Parametern funktioniert das genau so, man kann aber nur in manchen Programmiersprachen einen ausgewählten Parameter setzen.  
`int function foo (int n = 10, bool b = true){`  
`}`  
`int meineVar = foo(b = false);`  
## Call-by-Value vs Call-by-Reference [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei Call-by-Value und Call-by-Reference geht es um die unterschiedlichen Speicherverwaltungen, wenn eine Variable als Argument an eine Funktiuon übergeben wird.  

Teilweise hat man die Kontrolle darüber welche Speicherverwaltung hier gentuzt wird. Meißtens wird das aber automatisiert so das man selbst keine Kontrolle darüber hat. Es ist also von der Programmiersprache abhängig ob dies möglich ist oder nicht und bei welchen Typen das jeweilige Call-by Verfahren anwendet wird.  

Bei primitiven Datentypen (bool, char, short, int, long) wird meißtens ein Call-by-Value genutzt und bei Arrays und Listen ein Call-by-Reference, was wie gesagt unterschiedlich zwischen den Programmierpsrachen ist.  

In Java ist es bspw. genau so wie eben beschrieben, in C++ werden Zeiger verwendet, wenn man einen Call-by-Reference haben möchte und bei C# kann man ein Schlüsselwort mit angeben um ein Call-by-Reference nutzen zu können.  

Der Call-by-Value sorgt also dafür, dass eine Kopie des übergebenen Arguments erzeugt wird und diese innerhalb der Funktionen gentuzt wird ohne das die Variable die als Argument übergeben wurde verändert wird.  
`void function foo(int a){`  
    `a = 1337`  
`}`  
`int a = 42`  
`foo(a)`  
`print(a) // 42`  

Der Call-by-Reference sorgt dafür das die Speicheraddresse die auf die Variablen zeigt die als Argument übergeben wird an die Funktion übergeben wird, sodass sich die Variable innerhalb der Funktion ändert und man mit der geändert Variablen weiter arbeiten kann.  
`void function foo(List list){`  
    `list = {4, 5, 6}`  
`}`  
`List list = {1, 2, 3}`  
`foo(list)`  
`print(list) // 4, 5, 6`  

Um nun bspw. einen Integer mit einem Call-by-Reference aufrufen zu können, gibt es in manchen Programmiersprachen das Schlüsselwort `ref`.  
`void function foo(ref int a){`  
    `a = 1337`  
`}`  
`int a = 42`  
`foo(a)`  
`print(a) // 1337`  

Somit kann man im Prinzip mehrere Rückgabewerte aus einer Funktion herausbekommen.
## Lazy Evaluation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Normalerweise wird in Programmiersprachen eine Eager Evaluation durchgeführt die dafür sorgt das immer alle Bestandteile bspw. einer Liste aufgebaut und ausgeführt werden bevor man mit einem Index darauf zugreift.  
`List list = {42, 1337, sleep(3)}`  
`print(list[1])`  

Hier würde mit der Eager Evaluation die sleep-Funktion bei der Erstellung der Liste ausgeführt werden, obwohl wir gar nicht mit dem Index im weiteren Codefluss darauf zugreifen.  

Bei der Lazy Evaluation, die meißtens in funktionalen Programmiersprachen vorkommt, wird erst geschaut welches Element in der Liste gebraucht wird und dann wird nur das gewählte Element bzw. die gewählten Elemente aufgebaut und ausgeführt, was Rechenzeit spart.  
`List list = {42, 1337, sleep(3)}`  
`print(list[1])`  

Hier würde mit der Lazy Evaluation die sleep-Funktion bei der Erstellung der Liste nur ausgeführt werden, wenn wir mit dem Index im weiteren Codefluss darauf zugreifen würden. 
## Function Pointer [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Funktionen können auch wie eine Variable behandelt werden und erst später im Codefluss ausgeführt, werden in dem man Funktionszeiger nutzt.  
`function foo(){`  
    `return 1`  
`}`  
`var meineFkt = foo`  
`print(meineFkt()) // 1`  

Die Funktionszeiger können auch als Parameter übergeben werden, was häufig bei Loggern genutzt wird, bzw. wenn man seinen Output selbst schreiben möchte.  
`function foo(n, n2){`  
    `return n * n2`  
`}`  
`function bar (baz, n){`  
    `n2 = 1337`  
    `return baz(n, n2)`  
`}`  
`bar(foo,42)`  
## Lambda Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Definiert eine Funktion innerhalb von einer Zeile, was Rechenzeit erspart. Sie muss aber in eine Variable geschrieben werden, um sie nutzen zu können.  
`var fkt = (a, b) -> a * b // Java schreibweise`  
`fkt = lambda a, b: a * b // Python schreibweise`

Nun kann sie wie eine klassische Versionverwendet werden, mann kann sich auch erst in der Argumentenliste definieren.  
`bar (lambda a, b: a * b, 42)`  
## Inline Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Inline Funktionen sind Omptimierungen die zwar dafür sorgen das mehr Speicherbelegt wird, aber dafür sorgt, dass das die Rechenzeit kürzer ist.  
`inline function square(double a){`  
    `return a*a;`  
`}`  
`print(square(4));`  
`// Unter der Haube: print (4*4);`  

Im Prinzip wird hier an der Stelle wo die Funktion aufgerufen werden würde, der Inhalt der Funktion direkt in den Quelltext geschrieben ohne einen Funktuionsaufruf dazwischen zu haben.  
## Code lesen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Programmieren lern man am besten, in dem man sich auch fremden Code durchliest und diesen versteht.  

Dazu kann man sich bei den meißten Programmiersprachen die Referenzen des Sourcecode der eigenen Standard-Bibliothek ansehen.  
Java: http://hg.openjdk.java.net/jdk8/jdk8/jdk/file/687fd7c7986d/src/share/classes/java/lang  
C#: https://referencesource.microsoft.com/#mscorlib  
C++: https://en.cppreference.com/w/  

Hiervon kann man sich nun einzelne Funktionen oder Methoden angucken und versuchen zu versehen,  was genau beim Aufruf passiert.
## Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ist ein Konzept, welches mehr Struktur und Ordnung in ein Projekt bringt.  

Grade für große Projekte ist dieses Konzept essentiel wichtig, da so eine bessere Übersicht gegeben ist.  

Ein Klasse ist an sich eine Blaupause von etwas was konkretisiert werden kann.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
`}`  

Hier wird als eine Klasse `Schule` definiert die einen Wert für den Namen der Schule und einen Wert für die Anzahl der Schüler bereit stellt. Die Variablen haben hier fürs erste einen von der Programmiersprache definierten Standardwert zugewiesen bekommen, der bspw- beim String `null` oder ein Leerstring (`" "`) und beim Integer eine `0` sein kann.  

Diese kann jetzt instanziiert werden, es können also jetzt mehrere Schulen konretisiert werden.  
`Schule youtube = new Schule();`  
`youtube.name = "The Morpheus Tutorials";`  
`youtube.anzahlSchueler = 13000;`  
`Schule kit = new Schule();`  
`kit.name = "KIT";`  
`kit.anzahlSchueler = 23000;`  

Wenn sich also gewiise Gemeinsamkeiten bei mehreren Konstrukten abbilden lassen können, kann man hiermit sehr gut eine Klasse erstellen die diese Wert definiert, sodass die Werte nur noch deklariert werden müssen.  
## Methoden  [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Sind an sich auch nur Funktionen, die die besondere Eigenschaft haben direkt auch Variablen in der selben Klasse zugreifen zu können, bzw. bekommen diese die selbe Klasse unter der Haube zugewiesen.  

In den meißten Programmiersprachen wird das automaitsch von der Klasse übernommen, in Python wird aber bspw. das `self`-Schlüsselwort dazu als Parameter übergeben um diese Funktion gewährleisten zu können.  

Die meißten Programmiersprachen nutzen das `this`-Schlüsselwort um die Variablen inder der Klasse nutzen zu können, man kann sie aber auch ohne das Schlüsselwort direkt nutznen.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `function neuerSchueler(){`  
        `this.anzahlSchueler++;`  
    `}`  
`}`  
`Schule youtube = new Schule();`  
`youtube.name = "The Morpheus Tutorials";`  
`youtube.anzahlSchueler = 13000;`  
`youtube.neuerSchueler(); //anzahlSchueler = 13001`  

Hier wird bspw. die Variable `anzahlSchueler` nur durch den Methodenaufruf `neuerSchueler()` um 1 erhöht.  
## Konstruktoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ein Konstruktor ist die erste Methode die in einer Klasse aufgerufen wird und setzt standardmäßig alle Klassenvariablen auf einen Standardwert und belegt somit den dementsprechenden Speicher, was je nach Programmiersprache unterschiedlich ist. Man also eigentlich immer einen Standardkonstruktor der unter der Haube ausgeführt wird.  

Aufgerufen wird dieser Konstruktor bei der Erzeugung einer Instanz mit dem `new`-Schlüsselwort.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(){`  
        `name = "MeineSchule";`  
        `anzahlSchueler = 500;`  
    `}`  
`}`  
`Schule schule = new Schule();`  

Nun kann man auch einen eigenen Konstruktor schreiben, in dem man sogar eine Parameterliste einbauen kann. Wenn man das tut verfällt der Standardkonstruktor unter der Haube.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(string name, int anzahlSchueler){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule kit = new Schule("KIT", 23000);`  

Hier kann jetzt nur noch eine Instanz erzeugt werden, wenn die Parameterliste gefüllt ist.  

Das `this`-Schlüsselwort ist hier nun relevanter, da man hiermit sicherstellen kann, dass die Variable in der Klasse gemeint ist und nicht das Argument welches an die Funktion übergeben wird.  

Falls man jetzt Standardwerte für die Parameter des Kosntruktor setzten möchte, lann man von der Klasse auch wieder Instanzen erzeugen, die keinen Parameter übergeben bekommen.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(string name = "", int anzahlSchueler = 0){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule schule = new Schule();`
## Zugriffsmodifikatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Durch Zuggriffsmodifikatoren kann man den Zugriff auf eine Klasse steuern, wenn man bspw. verhindern möchte, dass eine Wert verändert wird.  

Die grundlegenenden Zugriffsmodifikatoren die es in so ziemlicher jeder Programmierpsrache gibt,  sind `public` und `private`. `public` ist meißtens der standardmäßige Zugriffsmodifikator und sorgt dafür das jeglicher Zugriff auf die Klassenvariable, Methode oder Klasse an sich erlaubt ist, während `private` dafür sorgt das nur ein Zugriff innerhalb der Klasse erlaubt ist.  
`public class Schule{`  
    `public string name;`  
    `private int anzahlSchueler;`  
    `public Schule(string name = "", int anzahlSchueler = 0){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule kit = new Schule("KIT", 23000);`  

Hier kann man zwar die Variable `int anzahlSchueler` beim Initialisieren durch den Konstruktor setzen, man kann aber durch das `private`-Schlüsselwort nicht mehr darauf zugreifen.  
## Getter/Setter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um nun `private` Variablen nur auslesbar oder nur schreibbar zu machen, gibt es sogenannte Getter- und Setter-Methoden, die dies druch einen Methodenaufruf ermöglichen.  
`public class Schule{`  
    `private int anzahlSchueler;`  
    `public Schule(int anzahlSchueler){`  
        `this.anzahlSchueler = anzahlSchueler;`  
    `}`  
    `public int getAnzahlSchueler(){`  
        `return anzahlSchueler;`  
    `}`  
`}`  
`Schule schule = new Schule(23000);`  
`int anzahlSchueler = schule.getAnzahlSchueler();`  

Hier kann man also nur noch die Variable auslesen und nicht mehr schreiben.  
`public class Schule{`  
    `private int anzahlSchueler;`  
    `public Schule(){`  
        `this.anzahlSchueler = 0;`  
    `}`  
    `public int getAnzahlSchueler(){`  
        `return anzahlSchueler;`  
    `}`  
    `public void setAnzahlSchueler(int anzahlSchueler){`  
        `if (anzahlSchueler >= 0){`
        `this.anzahlSchueler = anzahlSchueler;`  
        `}`
    `}`  
`}`  

Hier kann man durch den Setter dafür sorgen, dass die Anzahl der Schüler nur auf einen positiven Wert gesetzt wird.  

Wenn man also im Getter nur die Variable zurück gibt und im Setter nur die Variable setzt, kann man besser einfach die Variable auf `public` setzen.  
## Static - Klassenvariablen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Falls man einen Wert setzen möchte der für alle Instanzen einer Klasse gleich sien soll, benutzt man dazu `static`-Klassenvariablen.  
`public class Schule{`  
    `public static string gesetzesgrundlage = "SchG";`  
`}`  

Diese `static`-Klassenvariable ist nun für alle Instanzen gleich und sie belegt auch nur einmalig den Speicher.  
`Schule kit = new Schule();`  
`Schule youtube = new Schule();`  
`// kit.gesetzesgrundlage == youtube.gesetzesgrundlage`  

Je nach Programmierpsrache kann man diesen Wert jetzt ändern, dieser wird aber dann für alle Instanzen geändert.  
`// Schule.gesetzesgrundlage = "abc" o. kit.gesetzesgrundlage = "abc"`  

Man kann hier auch Getter- und Setter-Methoden benutzen nur müssen die auch `static` sein und man kann hier keine Variablen nutzen die nicht `static` sind.  

Da das `this`-Schlüsselwort auch nur für nicht statische Variablen funktioniert, nutzt man hier statt dessen den Klassennamen.  
`public class Schule{`  
    `private static string gesetzesgrundlage = "SchG";`  
    `public static string getGesetzesgrundlage(){`  
        `return Schule.gesetzesgrundlage;`  
    `}`  
`}`  
## Vererbung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Eine Vererbung ist eine Verbindung zwischen Klassen.  

Generell solte man beim Programmieren nie Copy-Pasten müssen, da man immer besser Funktion/Klassen erstellt oder von anderen erbt, um den selben Code mehrfach aufzurufen.  

Wenn man nun seine Klasse spezifizieren will und die selben Variablen und Methoden aus einer Klasse benötigt, kann man die Vererbung nutzen.  
`class Schule{`  
    `public string name;`  
    `public int anzahlSchueler;`  
`}`  
`class Gymnasium extends Schule{`  
`}`  

Hier kann man jetzt eine Instanz von der Klasse `Gymnasium` erzeugen und die gleichen Variablen aus der Klasse `Schule` nutzen, da diese quasi in die Klasse `Gymnasium` kopiert werden.  
`Gymnasium g = new Gymnasium();`  
`g.name = "MeinGymmi";`  
`g.anzahlSchueler = 400;`  

Der Klasse `Gymnasium` kann man jetzt auch eigene passende Variablen und Methoden hinzufügen und nutzen, diese haben dann natürlich nichts mehr mit der Klasse `Schule` zu tun.  
`class Schule{`  
    `public string name;`  
    `public int anzahlSchueler;`  
`}`  
`class Gymnasium extends Schule{`  
    `public string abschluss = "Abitur";`  
`}`  
`Gymnasium g = new Gymnasium();`  
`g.name = "MeinGymmi";`  
`g.anzahlSchueler = 400;`  
`string abschluss = g.abschluss;`
